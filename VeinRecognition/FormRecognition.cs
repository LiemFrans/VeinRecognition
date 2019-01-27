using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using libsvm;

namespace VeinRecognition
{
    public partial class FormRecognition : Form
    {
        private Dictionary<string, List<string>> trainingData;
        private Dictionary<string, List<string>> testingData;
        private double[,] feature;
        private GLCMFeatureExtraction glcm;
        private LearningVectorQuantization lvq = new LearningVectorQuantization();
        private double[,] weightAkhir;
        private int countFile;
        private int countFileTesting;
        private Stopwatch watch;
        private Bitmap testing;
        public FormRecognition()
        {
            InitializeComponent();
            rcAccuration.SelectionAlignment = HorizontalAlignment.Center;
            if (alreadyExtract())
            {
                btLoadTraining.Enabled = false;
                btExtraction.Enabled = false;
                btTraining.Enabled = true;
                btAccuration.Enabled = true;
                loadFileTraining();
                feature = openExtraction();
            }
        }
        private bool alreadyExtract()
        {
            var file = File.ReadLines("alreadyextract.txt").Cast<string>().ToList();
            return (file[0] == "yes" && Convert.ToInt16(file[1]) == Directory.GetFiles("Training", "*.bmp", SearchOption.AllDirectories).Count() && Convert.ToInt64(file[2]) == GetDirectorySize("./Training/")); ;
        }

        private long GetDirectorySize(string folder)
        {
            string[] a = Directory.GetFiles(folder, "*.bmp", SearchOption.AllDirectories);
            long b = 0;
            foreach (string name in a)
            {
                FileInfo info = new FileInfo(name);
                b += info.Length;
            }
            return b;
        }

        private void btLoadTraining_Click(object sender, EventArgs e)
        {
            loadFileTraining();
            btExtraction.Enabled = true;
        }

        private void loadFileTraining()
        {
            countFile = 0;
            watch = new Stopwatch();
            watch.Start();
            string[] allfiles = Directory.GetFiles("Training", "*.bmp", SearchOption.AllDirectories);
            trainingData = new Dictionary<string, List<string>>();
            var doc = new List<string>();
            string prev = allfiles[0].Split('\\')[2]+"\\"+ allfiles[0].Split('\\')[3];
            foreach (var f in allfiles)
            {
                string[] kelas = f.Split('\\');
                string now = kelas[2] + "\\" + kelas[3];
                if (prev != now)
                {
                    trainingData.Add(prev, doc);
                    doc = new List<string>();
                    doc.Add(f);
                    prev = now;
                    countFile++;
                }
                else
                {
                    doc.Add(f);
                    prev = now;
                    countFile++;
                }
            }
            trainingData.Add(prev, doc);
            foreach (var td in trainingData)
            {
                Console.WriteLine(td.Key);
                foreach (var d in td.Value)
                {
                    Console.WriteLine(d);
                }
            }
            watch.Stop();
            Console.WriteLine("Load Time Data Training : " + watch.Elapsed.TotalSeconds + " s");
        }

        private void btExtraction_Click(object sender, EventArgs e)
        {
            watch = new Stopwatch();
            watch.Start();
            feature = new double[countFile, 6];
            int i = 0;
            int j = 0;
            foreach(var c in trainingData)
            {
                foreach(var fimage in c.Value)
                {
                    glcm = new GLCMFeatureExtraction(new Clahe(8,8,256,10, new Bitmap(fimage)).Process(), Convert.ToInt32(numGrayLevel.Value));
                    //glcm = new GLCMFeatureExtraction(new Bitmap(fimage), Convert.ToInt32(numGrayLevel.Value));
                    glcm.extract();
                    feature[j, 0] = glcm.getContrast();
                    feature[j, 1] = glcm.getDissimilarity();
                    feature[j, 2] = glcm.getEnergy();
                    feature[j, 3] = glcm.getEntropy();
                    feature[j, 4] = glcm.getHomogenity();
                    feature[j, 5] = i;
                    j++;
                }
                Console.WriteLine("Extraction Class : " + i+", Now Time : "+watch.Elapsed.TotalSeconds+" s");
                i++;
            }
            featureToTxt();
            watch.Stop();
            Console.WriteLine("Extraction Time : " +watch.Elapsed.TotalSeconds+" s");
            btTraining.Enabled = true;
            btAccuration.Enabled = true;
        }

        private void featureToTxt()
        {
            Console.WriteLine("Feature save to TXT File");
            using (StreamWriter file = new StreamWriter("extraction.txt"))
                for(int i = 0; i < feature.GetLength(0); i++)
                {
                    for(int j = 0; j < feature.GetLength(1)-1; j++)
                    {
                        file.Write(feature[i,j]+",");
                    }
                    file.WriteLine(feature[i, feature.GetLength(1) - 1]);
                    //file.WriteLine("{0},{1},{2},{3},{4},{5}",feature[i,0],feature[i,1],feature[i,2],feature[i,3],feature[i,4],feature[i,5]);
                }
            using (StreamWriter file = new StreamWriter("alreadyextract.txt"))
            {
                file.WriteLine("yes");
                file.WriteLine(Directory.GetFiles("Training", "*.bmp", SearchOption.AllDirectories).Count());
                file.WriteLine(GetDirectorySize("./Training/"));
            }

        }

        private double[,] openExtraction()
        {
            watch = new Stopwatch();
            watch.Start();
            var file = File.ReadLines("extraction.txt").Cast<string>().ToList();
            var feature = new double[file.Count(),6];
            int i = 0; 
            foreach (string row in file)
            {
                string[] r = row.Split(',');
                int j = 0;
                foreach(var d in r)
                {
                    feature[i, j] = Double.Parse(d, CultureInfo.InvariantCulture);
                    j++;
                }
                i++;
            }
            return feature;
        }

        private double[,] generateWeightZero(int kelas, double[,] feature)
        {
            double[,] weight = new double[kelas, feature.GetLength(1) - 1];
            int neuron = 0;
            do
            {
                int i = 0;
                do
                {
                    if (feature[i, feature.GetLength(1) - 1] == neuron)
                    {
                        for (int j = 0; j < feature.GetLength(1) - 1; j++)
                        {
                            weight[neuron, j] = feature[i, j];
                        }
                        neuron++;
                    }
                    i++;
                } while (i < feature.GetLength(0));
            } while (neuron != weight.GetLength(0));
            return weight;
        }

        private void btTraining_Click(object sender, EventArgs e)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            int kelas = trainingData.Count();
            Console.WriteLine("Fitur " + kelas);
            int fitur = feature.GetLength(1);
            double[,] weight = generateWeightZero(kelas, feature);
            //double[,] weight = new double[kelas, fitur];
            //Random nilai = new Random();
            //for (int i = 0; i < weight.GetLength(0); i++)
            //{
            //    for (int j = 0; j < weight.GetLength(1); j++)
            //    {
            //        weight[i, j] = nilai.NextDouble();
            //    }
            //}
            Console.WriteLine("weight Zero");
            for (int i = 0; i < weight.GetLength(0); i++)
            {
                for (int j = 0; j < weight.GetLength(1); j++)
                {
                    Console.Write(weight[i, j] + " ");
                }Console.WriteLine();
            }
            Console.WriteLine("weight Akhir");
            weightAkhir = lvq.Training(feature, weight, Convert.ToDouble(numAlpha.Value),Convert.ToDouble(numBeta.Value), Convert.ToDouble(numMinLearningRate.Value));
            for(int i = 0; i < weightAkhir.GetLength(0); i++)
            {
                for(int j = 0; j < weightAkhir.GetLength(1); j++)
                {
                    Console.Write(weightAkhir[i, j]+" " );
                }
                Console.WriteLine();
            }
            Console.WriteLine("Epoch "+lvq.epoch);
            watch.Stop();
            Console.WriteLine("Training Time : " + watch.Elapsed.TotalSeconds+" s");
            btLoadTesting.Enabled = true;
            btAccuration.Enabled = true;
        }

        private void btLoadTesting_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                dlg.Filter = "bmp files (*.bmp)|*.bmp";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    tbTesting.Text = dlg.FileName;
                    testing = new Bitmap(dlg.FileName);
                    pbTesting.Image = testing;
                    pbTesting.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
            btTesting.Enabled = true;
        }

        private void btTesting_Click(object sender, EventArgs e)
        {
            int res = testingDataImage(testing);
            string dictres = trainingData.ElementAt(res).Key;
            Console.WriteLine(dictres);
            imageListResult.Images.Clear();
            listImageView.Clear();
            tbResult.Text = "Training\\Palm\\" + dictres;
            string[] dir = Directory.GetFiles("Training\\Palm\\"+dictres, "*.bmp", SearchOption.AllDirectories);
            foreach (string file in dir)
            {
                    this.imageListResult.Images.Add(Image.FromFile(file));
            }
            this.listImageView.View = View.LargeIcon;
            this.imageListResult.ImageSize = new Size(256, 192);
            this.listImageView.LargeImageList = this.imageListResult;
            for (int j = 0; j < this.imageListResult.Images.Count; j++)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = j;
                this.listImageView.Items.Add(item);
            }
        }

        private int testingDataImage(Image img)
        {
            glcm = new GLCMFeatureExtraction(new Clahe(8,8,256,10, new Bitmap(img)).Process(), Convert.ToInt16(numGrayLevel.Value));
            //glcm = new GLCMFeatureExtraction(img, Convert.ToInt32(numGrayLevel.Value));
            double[] testGlcm = new double[5];
            glcm.extract();
            testGlcm[0] = glcm.getContrast();
            testGlcm[1] = glcm.getDissimilarity();
            testGlcm[2] = glcm.getEnergy();
            testGlcm[3] = glcm.getEntropy();
            testGlcm[4] = glcm.getHomogenity();
            return lvq.testing(testGlcm, weightAkhir);
        }
        private void listImageView_DoubleClick(object sender, EventArgs e)
        {
            Console.WriteLine();
        }

        private void btAccuration_Click(object sender, EventArgs e)
        {
            loadFileTesting();
            extractionTestingAccuration();
        }
        private void loadFileTesting()
        {
            countFileTesting = 0;
            watch = new Stopwatch();
            watch.Start();
            string[] allfiles = Directory.GetFiles("Testing", "*.bmp", SearchOption.AllDirectories);
            testingData = new Dictionary<string, List<string>>();
            var doc = new List<string>();
            string prev = allfiles[0].Split('\\')[2] + "\\" + allfiles[0].Split('\\')[3];
            foreach (var f in allfiles)
            {
                string[] kelas = f.Split('\\');
                string now = kelas[2] + "\\" + kelas[3];
                if (prev != now)
                {
                    testingData.Add(prev, doc);
                    doc = new List<string>();
                    doc.Add(f);
                    prev = now;
                    countFileTesting++;
                }
                else
                {
                    doc.Add(f);
                    prev = now;
                    countFileTesting++;
                }
            }
            testingData.Add(prev, doc);
            foreach (var td in testingData)
            {
                Console.WriteLine(td.Key);
                foreach (var d in td.Value)
                {
                    Console.WriteLine(d);
                }
            }
            watch.Stop();
            Console.WriteLine("Load Time Data Testing: " + watch.Elapsed.TotalSeconds + " s");
        }
        private void extractionTestingAccuration()
        {
            watch = new Stopwatch();
            watch.Start();
            int i = 0;
            int correct = 0;
            foreach (var c in testingData)
            {
                foreach (var fimage in c.Value)
                {
                    bool corr = false;
                    var featureAccuration = new double[5];
                    glcm = new GLCMFeatureExtraction(new Clahe(8, 8, 256, 10, new Bitmap(fimage)).Process(), Convert.ToInt32(numGrayLevel.Value));
                    //glcm = new GLCMFeatureExtraction(new Bitmap(fimage), Convert.ToInt32(numGrayLevel.Value));
                    glcm.extract();
                    featureAccuration[ 0] = glcm.getContrast();
                    featureAccuration[ 1] = glcm.getDissimilarity();
                    featureAccuration[ 2] = glcm.getEnergy();
                    featureAccuration[ 3] = glcm.getEntropy();
                    featureAccuration[ 4] = glcm.getHomogenity();
                    int r = lvq.testing(featureAccuration, weightAkhir);
                    if (r == i)
                    {
                        correct++;
                        corr = true;
                    }
                    Console.WriteLine("Accuration File : " + fimage + ", Acc = "+corr+", result = Class-"+r+", Now Time : " + watch.Elapsed.TotalSeconds + " s");
                }
                i++;
            }
            double accurate = ((double)correct / (double)countFileTesting) * 100;
            rcAccuration.Text = accurate+" %";
            rcAccuration.SelectionAlignment = HorizontalAlignment.Center;
            watch.Stop();
            Console.WriteLine("Time Elapsed : " + watch.Elapsed.TotalSeconds + " s");
        }

        //private void svmLearning()
        //{
        //    var featureInfo = new double[feature.GetLength(0), 5];
        //    var classInfo = new double[feature.GetLength(0)];
        //    for(int i = 0; i < feature.GetLength(0); i++)
        //    {
        //        for(int j = 0; j < feature.GetLength(1)-1; j++)
        //        {
        //            featureInfo[i, j] = feature[i, j];
        //        }
        //        classInfo[i] = feature[i,feature.GetLength(0)-1];
        //    }
        //    var model = new C_SVC()
        //}
    }
}
