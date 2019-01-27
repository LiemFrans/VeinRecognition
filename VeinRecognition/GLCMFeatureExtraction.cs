using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeinRecognition
{
    class GLCMFeatureExtraction
    {
        private Image image;
        private int[,] grayLeveledMatrix;
        private int grayLevel;
        private double contrast;
        private double homogenity;
        private double entropy;
        private double energy;
        private double dissimilarity;

        public GLCMFeatureExtraction(Image image, int grayLevel)
        {
            this.image = image;
            this.grayLevel = grayLevel;
            grayLeveledMatrix = new int[this.image.Width, this.image.Height];
        }

        public void extract()
        {
            this.createGrayLeveledMatrix();
            //0°
            int[,] cm0 = createCoOccuranceMatrix(0);
            double[,] cm0SN = normalizeMatrix(add(cm0, transposeMatrix(cm0)));
        
            //45°
            int[,] cm45 = createCoOccuranceMatrix(45);
            double[,] cm45SN = normalizeMatrix(add(cm45, transposeMatrix(cm45)));

            //90°
            int[,] cm90 = createCoOccuranceMatrix(90);
            double[,] cm90SN = normalizeMatrix(add(cm90, transposeMatrix(cm90)));

            //135°
            int[,] cm135 = createCoOccuranceMatrix(135);
            double[,] cm135SN = normalizeMatrix(add(cm135, transposeMatrix(cm135)));

            this.contrast = (double)(calcContrast(cm0SN) + calcContrast(cm45SN) + calcContrast(cm90SN) + calcContrast(cm135SN)) / 4;
            this.homogenity = (double)(calcHomogenity(cm0SN) + calcHomogenity(cm45SN) + calcHomogenity(cm90SN) + calcHomogenity(cm135SN)) / 4;
            this.entropy = (double)(calcEntropy(cm0SN) + calcEntropy(cm45SN) + calcEntropy(cm90SN) + calcEntropy(cm135SN)) / 4;
            this.energy = (double)(calcEnergy(cm0SN) + calcEnergy(cm45SN) + calcEnergy(cm90SN) + calcEnergy(cm135SN)) / 4;
            this.dissimilarity = (double)(calcDissimilarity(cm0SN) + calcDissimilarity(cm45SN) + calcDissimilarity(cm90SN) + calcDissimilarity(cm135SN)) / 4;
        }


        private void createGrayLeveledMatrix()
        {
            Bitmap img = new Bitmap(image);
            int width = img.Width;
            int height = img.Height;
            for (int i = 0; i < image.Width; i++)
            {
                for (int j = 0; j < image.Height; j++)
                {
                    Color rgb = img.GetPixel(i, j);
                    int newR = rgb.R;
                    int newG = rgb.G;
                    int newB = rgb.B;
                    int newA = rgb.A;
                    int gr = (newR + newG + newB) / 3;

                    if (grayLevel > 0 && grayLevel < 255)
                    {
                        grayLeveledMatrix[i,j] = gr * grayLevel / 255;
                    }
                    else
                    {
                        grayLeveledMatrix[i,j] = gr;
                    }
                }
            }
        }
        private int[,] createCoOccuranceMatrix(int angle)
        { //distance = 1
            int[,] temp = new int[grayLevel + 1,grayLevel + 1];
            int startRow = 0;
            int startColumn = 0;
            int endColumn = 0;

            Boolean validAngle = true;
            switch (angle)
            {
                case 0:
                    startRow = 0;
                    startColumn = 0;
                    endColumn = grayLeveledMatrix.GetLength(1) - 2;
                    break;
                case 45:
                    startRow = 1;
                    startColumn = 0;
                    endColumn = grayLeveledMatrix.GetLength(1) - 2;
                    break;
                case 90:
                    startRow = 1;
                    startColumn = 0;
                    endColumn = grayLeveledMatrix.GetLength(1) - 1;
                    break;
                case 135:
                    startRow = 1;
                    startColumn = 1;
                    endColumn = grayLeveledMatrix.GetLength(1) - 1;
                    break;
                default:
                    validAngle = false;
                    break;
            }

            if (validAngle)
            {
                for (int i = startRow; i < grayLeveledMatrix.GetLength(0); i++)
                {
                    for (int j = startColumn; j <= endColumn; j++)
                    {
                        switch (angle)
                        {
                            case 0:
                                temp[grayLeveledMatrix[i,j],grayLeveledMatrix[i,j + 1]]++;
                                break;
                            case 45:
                                temp[grayLeveledMatrix[i,j],grayLeveledMatrix[i - 1,j + 1]]++;
                                break;
                            case 90:
                                temp[grayLeveledMatrix[i,j],grayLeveledMatrix[i - 1,j]]++;
                                break;
                            case 135:
                                temp[grayLeveledMatrix[i,j],grayLeveledMatrix[i - 1,j - 1]]++;
                                break;
                        }
                    }
                }
            }
            return temp;
        }
        private int[,] transposeMatrix(int[,] m)
        {
            int[,] temp = new int[m.GetLength(1),m.GetLength(0)];
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    temp[j,i] = m[i,j];
                }
            }
            return temp;
        }
        private int[,] add(int[,] m2, int[,] m1)
        {
            int[,] temp = new int[m1.GetLength(1),m1.GetLength(0)];
            for (int i = 0; i < m1.GetLength(0); i++)
            {
                for (int j = 0; j < m1.GetLength(1); j++)
                {
                    temp[j,i] = m1[i,j] + m2[i,j];
                }
            }
            return temp;
        }
        private int getTotal(int[,] m)
        {
            int temp = 0;
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    temp += m[i,j];
                }
            }
            return temp;
        }
        private double[,] normalizeMatrix(int[,] m)
        {
            double[,] temp = new double[m.GetLength(1),m.GetLength(0)];
            int total = getTotal(m);
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    temp[j,i] = (double)m[i,j] / total;
                }
            }
            return temp;
        }
        private double calcContrast(double[,] matrix)
        {
            double temp = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    temp += matrix[i,j] * Math.Pow(i - j, 2);
                }
            }
            return temp;
        }
        private double calcHomogenity(double[,] matrix)
        {
            double temp = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    temp += matrix[i,j] / (1 + Math.Pow(i - j, 2));
                }
            }
            return temp;
        }
        private double calcEntropy(double[,] matrix)
        {
            double temp = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i,j] != 0)
                    {
                        temp += (matrix[i,j] * Math.Log10(matrix[i,j])) * -1;
                    }
                }
            }
            return temp;
        }

        private double calcEnergy(double[,] matrix)
        {
            double temp = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    temp += Math.Pow(matrix[i,j], 2);
                }
            }
            return temp;
        }

        private double calcDissimilarity(double[,] matrix)
        {
            double temp = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    temp += matrix[i,j] * Math.Abs(i - j);
                }
            }
            return temp;
        }
        public double getContrast()
        {
            return contrast;
        }

        public double getHomogenity()
        {
            return homogenity;
        }

        public double getEntropy()
        {
            return entropy;
        }

        public double getEnergy()
        {
            return energy;
        }

        public double getDissimilarity()
        {
            return dissimilarity;
        }

    }
}
