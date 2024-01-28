using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace WindowsFormsApp1
{
    class AbonentsManager  // Предполагаемые методы : Сортировка массива,Поиск в массиве, Удаление/добавление элементов в массив ...
    {
        public static Abonent[] abonents = new Abonent[0];


        public static void Resize(int newSize)
        {
            var buf_arr = abonents;
            abonents = new Abonent[newSize];
            for (int i = 0; i < abonents.Length && i < buf_arr.Length; i++)
            {
                abonents[i] = buf_arr[i];
            }
        }
        public static void AddToStart(Abonent value)
        {
            int size = abonents.Length;
            Resize(size + 1);
            for (int i = abonents.Length - 2; i >= 0; i--)
            {
                abonents[i + 1] = abonents[i];
                if (i == 0)
                {
                    abonents[i] = value;
                }
            }

        }
        public static void AddToEnd(Abonent value)
        {
            int size = abonents.Length;
            Resize(size + 1);
            abonents[abonents.Length - 1] = value;
        }
     
        public static void AddByIndex(int index, Abonent value)
        {
            if (index + 1 <= abonents.Length)
            {
                int size = abonents.Length;
                Resize(size + 1);
                for (int i = abonents.Length - 2; i >= 0; i--)
                {
                    abonents[i + 1] = abonents[i];
                    if (i == index)
                    {
                        abonents[i] = value;
                        break;
                    }
                }


            }
            if(index >= abonents.Length)
            {
                Array.Resize(ref abonents, abonents.Length + 1);
            }
        }
            public static void DelStart()
            {
                var buf_arr = new Abonent[AbonentsManager.abonents.Length - 1];
                for (int i = 0; i < buf_arr.Length; i++)
                {
                    buf_arr[i] = abonents[i + 1];
                }
                abonents = buf_arr;
            }
            public static void DelEnd()
            {
                int nsize = abonents.Length - 1;
                Resize(nsize);
            }
            public static void DelByIndex(int index)
            {
                var buf_arr = new Abonent[AbonentsManager.abonents.Length - 1];
                int j = 0;
                for (int i = 0; i < abonents.Length; i++)
                {
                    if (i != index)
                    {
                        buf_arr[j] = abonents[i];
                        j++;
                    }
                    else continue;

                }
                abonents = buf_arr;
            }
        public static void AddToEndF(Abonent value,ref Abonent[] abndFiltred)
        {
            int size = abndFiltred.Length;
            var buf_arr = abndFiltred;
            abndFiltred = new Abonent[size+1];
            for (int i = 0; i < abndFiltred.Length && i < buf_arr.Length; i++)
            {
                abndFiltred[i] = buf_arr[i];
            }
            abndFiltred[abndFiltred.Length - 1] = value;
        }
        public void CreateListFields(Abonent abnFilter,ref List<string> fieldsList)
        {
                fieldsList.Add(abnFilter.firstName);
                fieldsList.Add(abnFilter.middleName);
                fieldsList.Add(abnFilter.lastName);
                fieldsList.Add(abnFilter.city);
                fieldsList.Add(abnFilter.street);
                fieldsList.Add(abnFilter.house);
                fieldsList.Add(abnFilter.apartment);
                fieldsList.Add(abnFilter.number);
                fieldsList.Add(abnFilter.isPaired.ToString());
                fieldsList.Add(abnFilter.paymentType);
                fieldsList.Add(abnFilter.yearOfSet);
        }
        public Abonent[] Filter(Abonent abnFilter)
        {
            
            Abonent[] abonentsFiltred = new Abonent[0];
       
            List<string> fieldsList = new List<string>();
            List<string> nameFields = new List<string> { "firstName","middleName","lastName","city","street", "house", "apartment", "number",
                "isPaired","paymentType","yearOfSet"};
            CreateListFields(abnFilter,ref fieldsList);
            string strFilter = string.Empty;
            string currentAbn = string.Empty;
            List<string> AbonentsStrList = new List<string>(abonents.Length);
            for(int i = 0;i<abonents.Length;i++)
            {
                AbonentsStrList.Add(string.Empty);
            }
            int filedIndex = 0;
            foreach(var item in fieldsList)
            {
                if(item!=null)
                {
                    strFilter += item;
                    for(int i = 0; i<abonents.Length;i++)
                    {
                        Type type = abonents[i].GetType();
                        var propertie = type.GetProperty(nameFields[filedIndex]);
                        currentAbn = propertie.GetValue(abonents[i]).ToString();
                        AbonentsStrList[i] += currentAbn;
                    }
                }
                filedIndex++;
            }
            int z = 0;
            foreach(var item in AbonentsStrList)
            {
                if(item == strFilter)
                {
                    AddToEndF(abonents[z], ref abonentsFiltred);
                }
                z++;
            }
            return abonentsFiltred;
        }

        public Abonent[] SortOneField(int? indexColumnToSort,bool isAscending,bool isDescending)
        {
            Abonent[] sortedAbonetsArray = abonents;
            List<string> namesFields = new List<string> { "firstName","middleName","lastName","city","street", "house", "apartment", "number",
                "isPaired","paymentType","yearOfSet"};
            if (isAscending)
            {
                switch (indexColumnToSort)
                {
                    case 0:
                        {
                            Array.Sort(sortedAbonetsArray, (x, y) => String.Compare(Convert.ToString(y.firstName), Convert.ToString(x.firstName)));
                            break;
                        }
                    case 1:
                        {
                            Array.Sort(sortedAbonetsArray, (x, y) => String.Compare(Convert.ToString(y.middleName), Convert.ToString(x.middleName)));
                            break;
                        }
                    case 2:
                        {
                            Array.Sort(sortedAbonetsArray, (x, y) => String.Compare(Convert.ToString(y.lastName), Convert.ToString(x.lastName)));
                            break;
                        }
                    case 3:
                        {
                            Array.Sort(sortedAbonetsArray, (x, y) => String.Compare(Convert.ToString(y.city), Convert.ToString(x.city)));
                            break;
                        }
                    case 4:
                        {
                            Array.Sort(sortedAbonetsArray, (x, y) => String.Compare(Convert.ToString(y.street), Convert.ToString(x.street)));
                            break;
                        }
                    case 5:
                        {
                            Array.Sort(sortedAbonetsArray, (x, y) => String.Compare(Convert.ToString(y.house), Convert.ToString(x.house)));
                            break;
                        }
                    case 6:
                        {
                            Array.Sort(sortedAbonetsArray, (x, y) => String.Compare(Convert.ToString(y.apartment), Convert.ToString(x.apartment)));
                            break;
                        }
                    case 7:
                        {
                            Array.Sort(sortedAbonetsArray, (x, y) => String.Compare(Convert.ToString(y.number), Convert.ToString(x.number)));
                            break;
                        }
                    case 8:
                        {
                            Array.Sort(sortedAbonetsArray, (x, y) => String.Compare(Convert.ToString(y.isPaired), Convert.ToString(x.isPaired)));
                            break;
                        }
                    case 9:
                        {
                            Array.Sort(sortedAbonetsArray, (x, y) => String.Compare(Convert.ToString(y.paymentType), Convert.ToString(x.paymentType)));
                            break;
                        }
                    case 10:
                        {
                            Array.Sort(sortedAbonetsArray, (x, y) => String.Compare(Convert.ToString(y.yearOfSet), Convert.ToString(x.yearOfSet)));
                            break;
                        }
                }
            }
           else
            {
                switch (indexColumnToSort)
                {
                    case 0:
                        {
                            Array.Sort(sortedAbonetsArray, (x, y) => String.Compare(Convert.ToString(x.firstName), Convert.ToString(y.firstName)));
                            break;
                        }
                    case 1:
                        {
                            Array.Sort(sortedAbonetsArray, (x, y) => String.Compare(Convert.ToString(x.middleName), Convert.ToString(y.middleName)));
                            break;
                        }
                    case 2:
                        {
                            Array.Sort(sortedAbonetsArray, (x, y) => String.Compare(Convert.ToString(x.lastName), Convert.ToString(y.lastName)));
                            break;
                        }
                    case 3:
                        {
                            Array.Sort(sortedAbonetsArray, (x, y) => String.Compare(Convert.ToString(x.city), Convert.ToString(y.city)));
                            break;
                        }
                    case 4:
                        {
                            Array.Sort(sortedAbonetsArray, (x, y) => String.Compare(Convert.ToString(x.street), Convert.ToString(y.street)));
                            break;
                        }
                    case 5:
                        {
                            Array.Sort(sortedAbonetsArray, (x, y) => String.Compare(Convert.ToString(x.house), Convert.ToString(y.house)));
                            break;
                        }
                    case 6:
                        {
                            Array.Sort(sortedAbonetsArray, (x, y) => String.Compare(Convert.ToString(x.apartment), Convert.ToString(y.apartment)));
                            break;
                        }
                    case 7:
                        {
                            Array.Sort(sortedAbonetsArray, (x, y) => String.Compare(Convert.ToString(x.number), Convert.ToString(y.number)));
                            break;
                        }
                    case 8:
                        {
                            Array.Sort(sortedAbonetsArray, (x, y) => String.Compare(Convert.ToString(x.isPaired), Convert.ToString(y.isPaired)));
                            break;
                        }
                    case 9:
                        {
                            Array.Sort(sortedAbonetsArray, (x, y) => String.Compare(Convert.ToString(x.paymentType), Convert.ToString(y.paymentType)));
                            break;
                        }
                    case 10:
                        {
                            Array.Sort(sortedAbonetsArray, (x, y) => String.Compare(Convert.ToString(x.yearOfSet), Convert.ToString(y.yearOfSet)));
                            break;
                        }
                }
            }
            return sortedAbonetsArray;
        }

        public Abonent[] MultiSort(bool[] sortParams,bool ascending,bool descending)
        {
            Abonent[] sortedAbonents = abonents;
            List<string> nameFields = new List<string> { "firstName","middleName","lastName","city","street", "house", "apartment", "number",
                "isPaired","paymentType","yearOfSet"};

            int index = 0;
            foreach (var item in sortedAbonents)
            {
                string sort = string.Empty;
                for (int i = 0; i<nameFields.Count;i++)
                {
                    if(sortParams[i] == true)
                    {
                        Type type = sortedAbonents[index].GetType();
                        var propertie = type.GetProperty(nameFields[i]);
                        sort += propertie.GetValue(sortedAbonents[index]).ToString()+" ";
                    }
                }
                item.SetSortString(sort);
                index++;
            }
            if(ascending==true)
            {
                Array.Sort(sortedAbonents, (x, y) => String.Compare(Convert.ToString(y.GetSortString()), Convert.ToString(x.GetSortString())));
            }
            else if(descending==true)
            {
                Array.Sort(sortedAbonents, (x, y) => String.Compare(Convert.ToString(x.GetSortString()), Convert.ToString(y.GetSortString())));
            }
            return sortedAbonents;
            }
            
        }
}




