using System;
using System.Collections.Generic;
using System.Linq;

namespace Neuro_COVID
{
    public class Kohanen_Data
    {
        //Info
        string _name;
        string _anomaly;
        string _genetic_illness;
        int _mother;
        double _time_pregnancy_ill;
        int _son;
        double _time_ill;
        double _time_gestagration;
        double _time_observation;
        //Otoacustic
        double _otoacoustic_r_1;
        double _otoacoustic_r_2;
        double _otoacoustic_r_4;
        double _otoacoustic_r_6;
        double _otoacoustic_l_1;
        double _otoacoustic_l_2;
        double _otoacoustic_l_4;
        double _otoacoustic_l_6;
        double _otoacoustic_r_05_15;
        double _otoacoustic_r_15_25;
        double _otoacoustic_r_25_35;
        double _otoacoustic_r_35_45;
        double _otoacoustic_r_45_55;
        double _otoacoustic_l_05_15;
        double _otoacoustic_l_15_25;
        double _otoacoustic_l_25_35;
        double _otoacoustic_l_35_45;
        double _otoacoustic_l_45_55;
        //Assr
        double _aSSR_r_05;
        double _aSSR_r_1;
        double _aSSR_r_2;
        double _aSSR_r_4;
        double _aSSR_l_05;
        double _aSSR_l_1;
        double _aSSR_l_2;
        double _aSSR_l_4;
        //KSVP
        double _kSVP_r_20;
        double _kSVP_r_40;
        double _kSVP_r_60;
        double _kSVP_l_20;
        double _kSVP_l_40;
        double _kSVP_l_60;

        public Kohanen_Data(string[] array)
        {
            _name = array[0];
            _anomaly = array[1];
            _genetic_illness = array[2];
            _mother = Convert.ToInt32(array[3]);
            _time_pregnancy_ill = Convert.ToInt32(array[4]);
            _son = Convert.ToInt32(array[5]);
            _time_ill = Convert.ToDouble(array[6]);
            _time_gestagration = Convert.ToDouble(array[7]);
            _time_observation = check_Time_observ(Convert.ToDouble(array[8]));
            _otoacoustic_r_1 = (array[9] == "") ? Double.NaN : Convert.ToDouble(array[9]);
            _otoacoustic_r_2 = (array[10] == "") ? Double.NaN : Convert.ToDouble(array[10]);
            _otoacoustic_r_4 = (array[11] == "") ? Double.NaN : Convert.ToDouble(array[11]);
            _otoacoustic_r_6 = (array[12] == "") ? Double.NaN : Convert.ToDouble(array[12]);
            _otoacoustic_l_1 = (array[13] == "") ? Double.NaN : Convert.ToDouble(array[13]);
            _otoacoustic_l_2 = (array[14] == "") ? Double.NaN : Convert.ToDouble(array[14]);
            _otoacoustic_l_4 = (array[15] == "") ? Double.NaN : Convert.ToDouble(array[15]);
            _otoacoustic_l_6 = (array[16] == "") ? Double.NaN : Convert.ToDouble(array[16]);
            _otoacoustic_r_05_15 = (array[17] == "") ? Double.NaN : Convert.ToDouble(array[17]);
            _otoacoustic_r_15_25 = (array[18] == "") ? Double.NaN : Convert.ToDouble(array[18]);
            _otoacoustic_r_25_35 = (array[19] == "") ? Double.NaN : Convert.ToDouble(array[19]);
            _otoacoustic_r_35_45 = (array[20] == "") ? Double.NaN : Convert.ToDouble(array[20]);
            _otoacoustic_r_45_55 = (array[21] == "") ? Double.NaN : Convert.ToDouble(array[21]);
            _otoacoustic_l_05_15 = (array[22] == "") ? Double.NaN : Convert.ToDouble(array[22]);
            _otoacoustic_l_15_25 = (array[23] == "") ? Double.NaN : Convert.ToDouble(array[23]);
            _otoacoustic_l_25_35 = (array[24] == "") ? Double.NaN : Convert.ToDouble(array[24]);
            _otoacoustic_l_35_45 = (array[25] == "") ? Double.NaN : Convert.ToDouble(array[25]);
            _otoacoustic_l_45_55 = (array[26] == "") ? Double.NaN : Convert.ToDouble(array[26]);
            _aSSR_r_05 = (array[27] == "") ? Double.NaN : Convert.ToDouble(array[27]);
            _aSSR_r_1 = (array[28] == "") ? Double.NaN : Convert.ToDouble(array[28]);
            _aSSR_r_2 = (array[29] == "") ? Double.NaN : Convert.ToDouble(array[29]);
            _aSSR_r_4 = (array[30] == "") ? Double.NaN : Convert.ToDouble(array[30]);
            _aSSR_l_05 = (array[31] == "") ? Double.NaN : Convert.ToDouble(array[31]);
            _aSSR_l_1 = (array[32] == "") ? Double.NaN : Convert.ToDouble(array[32]);
            _aSSR_l_2 = (array[33] == "") ? Double.NaN : Convert.ToDouble(array[33]);
            _aSSR_l_4 = (array[34] == "") ? Double.NaN : Convert.ToDouble(array[34]);
            _kSVP_r_20 = (array[35] == "") ? Double.NaN : Convert.ToDouble(array[35]);
            _kSVP_r_40 = (array[36] == "") ? Double.NaN : Convert.ToDouble(array[36]);
            _kSVP_r_60 = (array[37] == "") ? Double.NaN : Convert.ToDouble(array[37]);
            _kSVP_l_20 = (array[38] == "") ? Double.NaN : Convert.ToDouble(array[38]);
            _kSVP_l_40 = (array[39] == "") ? Double.NaN : Convert.ToDouble(array[39]);
            _kSVP_l_60 = (array[40] == "") ? Double.NaN : Convert.ToDouble(array[40]);
        }
        
        private double check_Time_observ(double time)
        {
            if (time <= 3.0)
                return 3.0;
            if (time <= 6.0)
                return 6.0;
            if (time <= 9.0)
                return 9.0;
            if (time <= 12.0)
                return 12.0;
            return 16.0;
        }

        public string[] OutPut_Info()
        {
            return new string[] {_name,
                                                _anomaly,
                                                _genetic_illness,
                                                _mother.ToString(),
                                                _time_pregnancy_ill.ToString(),
                                                _son.ToString(),
                                                _time_ill.ToString(),
                                                _time_gestagration.ToString(),
                                                _time_observation.ToString(),
                                                _otoacoustic_r_1.ToString(),
                                                _otoacoustic_r_2.ToString(),
                                                _otoacoustic_r_4.ToString(),
                                                _otoacoustic_r_6.ToString(),
                                                _otoacoustic_l_1.ToString(),
                                                _otoacoustic_l_2.ToString(),
                                                _otoacoustic_l_4.ToString(),
                                                _otoacoustic_l_6.ToString(),
                                                _otoacoustic_r_05_15.ToString(),
                                                _otoacoustic_r_15_25.ToString(),
                                                _otoacoustic_r_25_35.ToString(),
                                                _otoacoustic_r_35_45.ToString(),
                                                _otoacoustic_r_45_55.ToString(),
                                                _otoacoustic_l_05_15.ToString(),
                                                _otoacoustic_l_15_25.ToString(),
                                                _otoacoustic_l_25_35.ToString(),
                                                _otoacoustic_l_35_45.ToString(),
                                                _otoacoustic_l_45_55.ToString(),
                                                _aSSR_r_05.ToString(),
                                                _aSSR_r_1.ToString(),
                                                _aSSR_r_2.ToString(),
                                                _aSSR_r_4.ToString(),
                                                _aSSR_l_05.ToString(),
                                                _aSSR_l_1.ToString(),
                                                _aSSR_l_2.ToString(),
                                                _aSSR_l_4.ToString(),
                                                _kSVP_r_20.ToString(),
                                                _kSVP_r_40.ToString(),
                                                _kSVP_r_60.ToString(),
                                                _kSVP_l_20.ToString(),
                                                _kSVP_l_40.ToString(),
                                                _kSVP_l_60.ToString()};
        }

        public double[] DataForClasterisation()
        {
            return new double[]  {              _mother, 
                                                _time_pregnancy_ill, 
                                                _son, 
                                                _time_ill,
                                                _time_gestagration,
                                                _time_observation,
                                                _otoacoustic_r_1,
                                                _otoacoustic_r_2,
                                                _otoacoustic_r_4,
                                                _otoacoustic_r_6,
                                                _otoacoustic_l_1,
                                                _otoacoustic_l_2,
                                                _otoacoustic_l_4,
                                                _otoacoustic_l_6,
                                                _otoacoustic_r_05_15,
                                                _otoacoustic_r_15_25,
                                                _otoacoustic_r_25_35,
                                                _otoacoustic_r_35_45,
                                                _otoacoustic_r_45_55,
                                                _otoacoustic_l_05_15,
                                                _otoacoustic_l_15_25,
                                                _otoacoustic_l_25_35,
                                                _otoacoustic_l_35_45,
                                                _otoacoustic_l_45_55,
                                                _aSSR_r_05,
                                                _aSSR_r_1,
                                                _aSSR_r_2,
                                                _aSSR_r_4,
                                                _aSSR_l_05,
                                                _aSSR_l_1,
                                                _aSSR_l_2,
                                                _aSSR_l_4,
                                                _kSVP_r_20,
                                                _kSVP_r_40,
                                                _kSVP_r_60,
                                                _kSVP_l_20,
                                                _kSVP_l_40,
                                                _kSVP_l_60};
        }
    }

    public class Kohanen_Func
    {
        public static List<string> colomnsData()
        {
            return new List<string>() {
                                                        "ФИО",
                                                        "Аномалии развития при рождении",
                                                        "Генетические заболевания",
                                                        "Мать",
                                                        "Срок беременности на момент болезни",
                                                        "Ребенок",
                                                        "Возраст на момент болезни",
                                                        "срок гестации на момент обследования(нед)",
                                                        "возраст на момент обследования",
                                                        "отоакустическая эмиссия Пр.уха 1кГц",
                                                        "отоакустическая эмиссия Пр.уха 2кГц",
                                                        "отоакустическая эмиссия Пр.уха 4кГц",
                                                        "отоакустическая эмиссия Пр.уха 6кГц",
                                                        "отоакустическая эмиссия Лев.уха 1кГц",
                                                        "отоакустическая эмиссия Лев.уха 2кГц",
                                                        "отоакустическая эмиссия Лев.уха 4кГц",
                                                        "отоакустическая эмиссия Лев.уха 6кГц",
                                                        "отоакустическая эмиссия Пр.уха 0,5-1,5кГц",
                                                        "отоакустическая эмиссия Пр.уха 1,5-2,5кГц",
                                                        "отоакустическая эмиссия Пр.уха 2,5-3,5кГц",
                                                        "отоакустическая эмиссия Пр.уха 3,5-4,5кГц",
                                                        "отоакустическая эмиссия Пр.уха 4,5-5,5кГц",
                                                        "отоакустическая эмиссия Лев.уха 0,5-1,5кГц",
                                                        "отоакустическая эмиссия Лев.уха 1,5-2,5кГц",
                                                        "отоакустическая эмиссия Лев.уха 2,5-3,5кГц",
                                                        "отоакустическая эмиссия Лев.уха 3,5-4,5кГц",
                                                        "отоакустическая эмиссия Лев.уха 4,5-5,5кГц",
                                                        "ASSR Пр.уха 500Гц",
                                                        "ASSR Пр.уха 1000Гц",
                                                        "ASSR Пр.уха 2000Гц",
                                                        "ASSR Пр.уха 4000Гц",
                                                        "ASSR Лев.уха 500Гц",
                                                        "ASSR Лев.уха 1000Гц",
                                                        "ASSR Лев.уха 2000Гц",
                                                        "ASSR Лев.уха 4000Гц",
                                                        "КСВП латентность Пр.уха 20",
                                                        "КСВП латентность Пр.уха 40",
                                                        "КСВП латентность Пр.уха 60",
                                                        "КСВП латентность Лев.уха 20",
                                                        "КСВП латентность Лев.уха 40",
                                                        "КСВП латентность Лев.уха 60"
                                                        };
        }

        public double[,] neuroStart(double[,] x_0)
        {
            int N = x_0.GetLength(1);
            int M = x_0.GetLength(0);
            //Нормализация данных
            double[] min = new double[N];
            double[] max = new double[N];
            double[,] b = new double[N, M];
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    if (Double.IsNaN(x_0[j, i]))
                        b[i, j] = 0;
                    else
                        b[i, j] = x_0[j, i];
                }
            }
            for (int i = 0; i < N; i++)
            {
                min[i] = b[i, 0];
                max[i] = b[i, 0];
                for (int j = 1; j < M; j++)
                {
                    min[i] = Math.Min(min[i], b[i, j]);
                    max[i] = Math.Max(max[i], b[i, j]);
                }
            }

            double[,] x = new double[M, N];
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    x[i, j] = (Double.IsNaN(x_0[i, j])) ? Double.NaN : Math.Round((x_0[i, j] - (min[j])) / (max[j] - min[j]), 2);
                    Console.Write(x[i, j] + " ");
                }
                Console.WriteLine();
            }

            return x;
        }

        public int[] listShafle(int[] a)
        {
            Random random = new Random();
            for (int i = a.Length - 1; i >= 1; i--)
            {
                int j = random.Next(i + 1);
                var temp = a[j];
                a[j] = a[i];
                a[i] = temp;
            }
            return a;
        }
        public double[] getStrOfArray(double[,] x, int index)
        {
            double[] str_of_array = new double[x.GetLength(1)];
            for (int i = 0; i < x.GetLength(1); i++)
                str_of_array[i] = x[index, i];
            return str_of_array;
        }
        public bool checkForChange(double[] x)
        {
            for (int j = 0; j < x.Length; j++)
                if (Double.IsNaN(x[j]))
                {
                    return false;
                }
            return true;
        }

        public double[,] WStartWithout(double[,] x, double Rk, double v, string[] koefs)
        {
            int count = 0;
            int N = x.GetLength(1);
            int M = x.GetLength(0);
            double[,] w = new double[M, N];
            for (int i = 0; i < M; i++)
                if (checkForChange(getStrOfArray(x, i))) {
                    for (int j = 0; j < N; j++)
                    {
                        w[0, j] = x[i, j];
                    }
                    break;
                }

            for (int i = 0; i < M; i++)
            {
                if (checkForChange(getStrOfArray(x, i)))
                {
                    double[] R = new double[count + 1];
                    for (int j = 0; j < (count + 1); j++)
                    {
                        for (int k = 0; k < N; k++)
                        {
                            double difference = x[i, k] - w[j, k];
                            double koef = (koefs == null) ? 1 : Convert.ToDouble(koefs[k]);
                            R[j] += koef * Math.Pow(difference, 2);
                        }
                        R[j] = Math.Sqrt(R[j]);
                    }

                    int bestR = 0;
                    double best = R[0];
                    for (int j = 0; j < R.Length; j++)
                    {
                        best = Math.Min(best, R[j]);
                        if (best == R[j]) { bestR = j; }
                    }
                    if (best <= Rk)
                    {
                        for (int j = 0; j < N; j++)
                        {
                            w[bestR, j] += v * (x[i, j] - w[bestR, j]);
                        }
                    }
                    else
                    {
                        count++;
                        for (int j = 0; j < N; j++)
                        {
                            w[count, j] = x[i, j];
                        }
                    }
                }
            }
            double[,] final_w = new double[count + 1, N];
            for (int i = 0; i < final_w.GetLength(0); i++) { 
                for (int j = 0; j < final_w.GetLength(1); j++)
                {
                    final_w[i, j] = w[i, j];
                }
            }
            return final_w;
        }

        public double[,] WCorrect(double[,] x, double v, int steps, double[,] w, string[] koefs)
        {
            double step = v / steps;
            int N = x.GetLength(1);
            int M = x.GetLength(0);
            int count = w.GetLength(0);
            //Изменение весовых коэффициентов
            for (int z = 0; z < steps; z++)
            {
                double new_v = v - step * z;
                int[] listforstep = Enumerable.Range(1, M).ToArray();
                listforstep = listShafle(listforstep);
                for (int i = 0; i < M; i++)
                {
                    
                    double[] R = new double[count];
                    int number = listforstep[i] - 1;
                    if (checkForChange(getStrOfArray(x, number)))
                    {
                        for (int j = 0; j < (count); j++)
                        {
                            for (int k = 0; k < N; k++)
                            {
                                double difference = x[number, k] - w[j, k];
                                double koef = (koefs == null) ? 1 : Convert.ToDouble(koefs[k]);
                                R[j] += koef * Math.Pow(difference, 2);
                            }
                            R[j] = Math.Sqrt(R[j]);
                        }
                        int bestR = 0;
                        double best = R[0];
                        for (int j = 0; j < R.Length; j++)
                        {
                            best = Math.Min(best, R[j]);
                            if (best == R[j]) { bestR = j; }
                        }
                        for (int j = 0; j < N; j++)
                        {
                            w[bestR, j] += new_v * (x[number, j] - w[bestR, j]);
                        }
                    }
                }
            }
            return w;
        }

        public string[] childInClusters(double[,] x, double[,] w, double Rk)
        {
            int M = x.GetLength(0);
            int N = x.GetLength(1);
            int count = w.GetLength(0);
            string[] ChildForClusters = new string[count];
            List<string> variables_w = new List<string>();
            for (int i = 0; i < M; i++)
            {
                if (checkForChange(getStrOfArray(x, i)))
                {
                    double[] R = new double[count];
                    for (int j = 0; j < (count); j++)
                    {
                        for (int k = 0; k < N; k++)
                        {
                            R[j] += Math.Pow(x[i, k] - w[j, k], 2);
                        }
                        R[j] = Math.Sqrt(R[j]);
                    }
                    int bestR = 0;
                    double best = R[0];
                    for (int j = 0; j < R.Length; j++)
                    {
                        Console.Write(R[j] + " ");
                        best = Math.Min(best, R[j]);
                        if (best == R[j]) { bestR = j; }
                    }
                    Console.WriteLine();
                    ChildForClusters[bestR] += " " + (i + 1).ToString();
                    if (!variables_w.Contains(bestR.ToString()))
                        variables_w.Add(bestR.ToString());
                }
            }
            int index = 0;
            string[] FinalChildForClusters = new string[variables_w.Count];
            for (int i = 0; i < count; i++)
                if (ChildForClusters[i] != null)
                {
                    FinalChildForClusters[index++] = ChildForClusters[i];
                    Console.WriteLine(FinalChildForClusters[index - 1]);
                }

            return FinalChildForClusters;
        }

        public double[] selectedPropNormal(int indexProp, double time_observ, double gestagration)
        {
            if (indexProp == 2 || indexProp == 6)
            {
                if (time_observ <= 3)
                {
                    if (gestagration <= 28)
                        return new double[] { -4.0, -2.0 };
                    else if (gestagration <= 32)
                        return new double[] { 0.0, 3.0 };
                    else if (gestagration <= 36)
                        return new double[] { 1.0, 4.0 };
                    else
                        return new double[] { 2.0, 5.0 };
                }
                else if (time_observ <= 6)
                {
                    if (gestagration <= 28)
                        return new double[] { 0.6, 4.0 };
                    else if (gestagration <= 32)
                        return new double[] { 2.0, 5.0 };
                    else if (gestagration <= 36)
                        return new double[] { 3.0, 5.0 };
                    else
                        return new double[] { 0.0, 5.0 };
                }
                else
                {
                    if (gestagration <= 28)
                        return new double[] { 3.0, 6.0 };
                    else if (gestagration <= 32)
                        return new double[] { 3.0, 6.0 };
                    else if (gestagration <= 36)
                        return new double[] { 4.0, 6.0 };
                    else
                        return new double[] { 3.0, 7.0 };
                }
            }
            if (indexProp == 3 || indexProp == 7)
            {
                if (time_observ <= 3)
                {
                    if (gestagration <= 28)
                        return new double[] { 11.0, 15.0 };
                    else if (gestagration <= 32)
                        return new double[] { 11.0, 14.0 };
                    else if (gestagration <= 36)
                        return new double[] { 12.0, 14.0 };
                    else
                        return new double[] { 12.0, 16.0 };
                }
                else if (time_observ <= 6)
                {
                    if (gestagration <= 28)
                        return new double[] { 13.0, 16.0 };
                    else if (gestagration <= 32)
                        return new double[] { 13.0, 15.0 };
                    else if (gestagration <= 36)
                        return new double[] { 14.0, 16.0 };
                    else
                        return new double[] { 10.0, 15.0 };
                }
                else
                {
                    if (gestagration <= 28)
                        return new double[] { 14.0, 17.0 };
                    else if (gestagration <= 32)
                        return new double[] { 12.0, 15.0 };
                    else if (gestagration <= 36)
                        return new double[] { 14.0, 16.0 };
                    else
                        return new double[] { 12.0, 15.0 };
                }
            }
            if(indexProp == 4 || indexProp == 8)
            {
                if (time_observ <= 3)
                {
                    if (gestagration <= 28)
                        return new double[] { 6.0, 11.0 };
                    else if (gestagration <= 32)
                        return new double[] { 9.0, 12.0 };
                    else if (gestagration <= 36)
                        return new double[] { 8.0, 10.0 };
                    else
                        return new double[] { 8.0, 13.0 };
                }
                else if (time_observ <= 6)
                {
                    if (gestagration <= 28)
                        return new double[] { 9.0, 12.0 };
                    else if (gestagration <= 32)
                        return new double[] { 11.0, 13.0 };
                    else if (gestagration <= 36)
                        return new double[] { 10.0, 12.0 };
                    else
                        return new double[] { 7.0, 10.0 };
                }
                else
                {
                    if (gestagration <= 28)
                        return new double[] { 11.0, 14.0 };
                    else if (gestagration <= 32)
                        return new double[] { 11.0, 13.0 };
                    else if (gestagration <= 36)
                        return new double[] { 10.0, 12.0 };
                    else
                        return new double[] { 7.0, 10.0 };
                }
            }
            if (indexProp == 5 || indexProp == 9)
            {
                if (time_observ <= 3)
                {
                    if (gestagration <= 28)
                        return new double[] { 4.0, 10.0 };
                    else if (gestagration <= 32)
                        return new double[] { 6.0, 10.0 };
                    else if (gestagration <= 36)
                        return new double[] { 7.0, 9.0 };
                    else
                        return new double[] { 8.0, 12.0 };
                }
                else if (time_observ <= 6)
                {
                    if (gestagration <= 28)
                        return new double[] { 7.0, 12.0 };
                    else if (gestagration <= 32)
                        return new double[] { 6.0, 9.0 };
                    else if (gestagration <= 36)
                        return new double[] { 7.0, 9.0 };
                    else
                        return new double[] { 4.0, 8.0 };
                }
                else
                {
                    if (gestagration <= 28)
                        return new double[] { 8.0, 12.0 };
                    else if (gestagration <= 32)
                        return new double[] { 6.0, 9.0 };
                    else if (gestagration <= 36)
                        return new double[] { 8.0, 11.0 };
                    else
                        return new double[] { 6.0, 10.0 };
                }
            }
            if (indexProp >= 20 && indexProp <= 27)
                return new double[] { 0.0001, 20.1 };
            if (indexProp > 27)
                return new double[] { 0.1, 25.0 };
            return null;
        }
    }
}
