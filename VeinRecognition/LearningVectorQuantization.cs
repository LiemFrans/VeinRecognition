using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeinRecognition
{
    class LearningVectorQuantization
    {
        public int epoch;
        public LearningVectorQuantization()
        {
            epoch = 0;
        }
        public double[,] Training(double[,] dataTraining, double[,] weight, double alpha, double beta, double minLearningRate)
        {
            epoch++;
            int c = weight.GetLength(0);
            if (alpha >= minLearningRate)
            {
                var d = new Dictionary<int, double>();
                for (int i = 0; i < c; i++)
                {
                    d.Add(i, 0);
                }
                for (int i = 0; i < dataTraining.GetLength(0); i++)
                {
                    bool doneUpdate = false;
                    for (int j = 0; j < c; j++)
                    {
                        double temp = 0;
                        for (int k = 0; k < dataTraining.GetLength(1) - 1; k++)
                        {
                            temp += Math.Pow(dataTraining[i, k] - weight[j, k], 2);
                        }
                        d[j] = Math.Sqrt(temp);
                    }
                    int kelasTraining = Convert.ToInt16(dataTraining[i, dataTraining.GetLength(1) - 1]);
                    int kelasWinner = getKelasWinner(d);
                    int kelasRunnerUp = getKelasRunnerUp(d);
                    double dWinner = getDistanceWinner(d);
                    double dRunnerUp = getDistanceRunnerUp(d);
                    Console.WriteLine(kelasWinner + " " + dWinner);
                    Console.WriteLine(kelasRunnerUp + " " + dRunnerUp);
                    //if (LVQ3(d, kelasTraining, kelasWinner, kelasRunnerUp, dWinner, dRunnerUp) && (doneUpdate == false))
                    //{
                    //    double[] tempArray = new double[dataTraining.GetLength(1)];
                    //    for (int j = 0; j < dataTraining.GetLength(1); j++)
                    //    {
                    //        tempArray[j] = dataTraining[i, j];
                    //    }
                    //    weight = updateWeightLVQ3(weight, alpha, beta, tempArray, d, kelasTraining, kelasWinner, kelasRunnerUp);
                    //    doneUpdate = true;
                    //}
                    //if (LVQ21(d, kelasTraining, kelasWinner, kelasRunnerUp, dWinner, dRunnerUp) && (doneUpdate == false))
                    //{
                    //    double[] tempArray = new double[dataTraining.GetLength(1)];
                    //    for (int j = 0; j < dataTraining.GetLength(1); j++)
                    //    {
                    //        tempArray[j] = dataTraining[i, j];
                    //    }
                    //    weight = updateWeightLVQ21(weight, alpha, tempArray, d, kelasWinner, kelasRunnerUp);
                    //    doneUpdate = true;
                    //}
                    //else if (LVQ2(d, kelasTraining, kelasWinner, kelasRunnerUp, dWinner, dRunnerUp))//NANTI TOLONG DICHECK
                    //{
                    //    double[] tempArray = new double[dataTraining.GetLength(1)];
                    //    for (int j = 0; j < dataTraining.GetLength(1); j++)
                    //    {
                    //        tempArray[j] = dataTraining[i, j];
                    //    }
                    //    weight = updateWeightLVQ2(weight, alpha, tempArray, d, kelasWinner, kelasRunnerUp);
                    //    doneUpdate = true;
                    //}
                    double[] tempArray = new double[dataTraining.GetLength(1)];
                    for (int j = 0; j < dataTraining.GetLength(1); j++)
                    {
                        tempArray[j] = dataTraining[i, j];
                    }
                    weight = updateWeightLVQ1(weight, alpha, tempArray, d, kelasWinner);
                }
                alpha = alpha * beta;
                return Training(dataTraining, weight, alpha, beta, minLearningRate);
            }
            else
            {
                return weight;
            }
        }
        private double[,]updateWeightLVQ1(double [,] weight, double alpha, double[] dataTraining, Dictionary<int, double> d, int kelasWinner)
        {
            for (int i = 0; i < weight.GetLength(0); i++)
            {
                for (int j = 0; j < weight.GetLength(1); j++)
                {
                    if (dataTraining[dataTraining.Length - 1]==kelasWinner)
                    {
                        weight[i, j] = weight[i, j] + alpha * (dataTraining[j] + weight[i, j]);
                    }
                    else if (dataTraining[dataTraining.Length - 1] != kelasWinner)
                    {
                        weight[i, j] = weight[i, j] + alpha * (dataTraining[j] - weight[i, j]);
                    }
                }
            }
            return weight;
        }
        private double[,] updateWeightLVQ2(double[,] weight, double alpha, double[] dataTraining, Dictionary<int, double> d, int kelasWinner, int kelasRunnerUp)
        {
            for (int i = 0; i < weight.GetLength(0); i++)
            {
                for (int j = 0; j < weight.GetLength(1); j++)
                {
                    if (dataTraining[dataTraining.Length - 1] == kelasWinner)
                    {
                        weight[i, j] = weight[i, j] - alpha * (dataTraining[j] - weight[i, j]);
                    }
                    else if (dataTraining[dataTraining.Length - 1] == kelasRunnerUp)
                    {
                        weight[i, j] = weight[i, j] + alpha * (dataTraining[j] - weight[i, j]);
                    }
                }
            }
            return weight;
        }
        private double[,] updateWeightLVQ21(double[,] weight, double alpha, double[] dataTraining, Dictionary<int, double> d, int kelasWinner, int kelasRunnerUp)
        {
            for (int i = 0; i < weight.GetLength(0); i++)
            {

                for (int j = 0; j < weight.GetLength(1); j++)
                {
                    if (dataTraining[dataTraining.Length - 1] == kelasWinner)
                    {
                        weight[i, j] = weight[i, j] + alpha * (dataTraining[j] - weight[i, j]);
                    }
                    else if (dataTraining[dataTraining.Length - 1] == kelasRunnerUp)
                    {
                        weight[i, j] = weight[i, j] - alpha * (dataTraining[j] - weight[i, j]);
                    }
                }
            }
            return weight;
        }
        private double[,] updateWeightLVQ3(double[,] weight, double alpha, double beta, double[] dataTraining, Dictionary<int, double> d, int kelasTraining, int kelasWinner, int kelasRunnerUp)
        {
            for (int i = 0; i < weight.GetLength(0); i++)
            {
                for (int j = 0; j < weight.GetLength(1); j++)
                {
                    if ((kelasWinner != kelasRunnerUp) && (kelasWinner == kelasTraining || kelasRunnerUp == kelasTraining))
                    {
                        if (dataTraining[dataTraining.Length - 1] == kelasWinner)
                        {
                            weight[i, j] = weight[i, j] + alpha * (dataTraining[j] - weight[i, j]);
                        }
                        else if (dataTraining[dataTraining.Length - 1] == kelasRunnerUp)
                        {
                            weight[i, j] = weight[i, j] - alpha * (dataTraining[j] - weight[i, j]);
                        }
                    }
                    else if (kelasWinner == kelasTraining)
                    {
                        if (dataTraining[dataTraining.Length - 1] == kelasWinner)
                        {
                            weight[i, j] = weight[i, j] + alpha * (dataTraining[j] - weight[i, j]);
                        }
                        else if (dataTraining[dataTraining.Length - 1] == kelasRunnerUp)
                        {
                            weight[i, j] = weight[i, j] + alpha * (dataTraining[j] - weight[i, j]);
                        }
                    }
                }
            }
            return weight;
        }

        private int getKelasWinner(Dictionary<int, double> d)
        {
            var items = from pair in d
                        orderby pair.Value ascending
                        select pair;
            return items.First().Key;
        }
        private int getKelasRunnerUp(Dictionary<int, double> d)
        {
            var items = from pair in d
                        orderby pair.Value ascending
                        select pair;
            return items.ToList()[1].Key;
        }
        private double getDistanceWinner(Dictionary<int, double> d)
        {
            var items = from pair in d
                        orderby pair.Value ascending
                        select pair;
            return items.First().Value;
        }
        private double getDistanceRunnerUp(Dictionary<int, double> d)
        {
            var items = from pair in d
                        orderby pair.Value ascending
                        select pair;
            return items.ToList()[1].Value;
        }
        private bool LVQ2(Dictionary<int, double> d, int kelasTraining, int kelasWinner, int kelasRunnerUp, double dWinner, double dRunnerUp)
        {
            if (kelasWinner != kelasRunnerUp && kelasTraining == kelasRunnerUp && ((dWinner/dRunnerUp)>1-0.35&&(dRunnerUp/dWinner)<1+0.35))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool LVQ21(Dictionary<int, double> d, int kelasTraining, int kelasWinner, int kelasRunnerUp, double dWinner, double dRunnerUp)
        {
            double min = Math.Min(dWinner / dRunnerUp, dRunnerUp / dWinner);
            double max = Math.Max(dWinner / dRunnerUp, dRunnerUp / dWinner);
            if ((kelasWinner == kelasTraining || kelasRunnerUp == kelasTraining) && (min > 1 - 0.35 && max < 1 + 0.35))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        private bool LVQ3(Dictionary<int, double> d, int kelasTraining, int kelasWinner, int kelasRunnerUp, double dWinner, double dRunnerUp)
        {
            return (Math.Min(dWinner / dRunnerUp, dRunnerUp / dWinner) > (1 - 0.2) * (1 + 0.2));
        }

        public int testing(double[] dataTesting, double[,] weight)
        {
            int c = weight.GetLength(0);
            var d = new Dictionary<int, double>();
            for (int i = 0; i < c; i++)
            {
                d.Add(i, 0);
            }
            for (int i = 0; i < c; i++)
            {
                double temp = 0;
                for (int j = 0; j < dataTesting.Length; j++)
                {
                    temp += Math.Pow(dataTesting[j] - weight[i, j], 2);
                }
                temp = Math.Sqrt(temp);
                d[i] = temp;
            }
            return getKelasWinner(d);
        }
        //private int testing(double[]dataTesting,int c)
        //{
        //    var d = new Dictionary<int, double>();
        //    for (int j = 0; j < c; j++)
        //    {
        //        double temp = 0;
        //        for (int k = 0; k < dataTesting.Length; k++)
        //        {
        //            temp += Math.Pow(dataTraining[i, j] - weight[j, k], 2);
        //        }
        //        d[j] = Math.Sqrt(temp);
        //    }
        //    return 0;
        //}
    }
}