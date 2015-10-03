using System;

//* Write a program that sorts an array of integers using the merge sort algorithm (find it in Wikipedia

class SortWithMergeSortAlogrithm
{
    static void Main()
    {
        //mergeSort(Element[] a, int l, int r){
        //if(l==r) return;
        //m = (r+l)/2; // Намиране на средата
        //mergeSort(a,l,m); // Рекурсивно сортиране на лявата част
        //mergeSort(a,m+1,r); // Рекурсивно сортиране на дясната част
        //j = l; k = m+1; // Сливане
        //for i=0 to r-l do
        //if(j>m) { b[i] = a[k]; k++; } // Лявата част е празна
        //else
        //if(k>r) { b[i] = a[j]; j++; } // Дясната част е празна
        //else
        //if(a[j]<=a[k]){ b[i] = a[j]; j++; }
        //else { b[i] = a[k]; k++; }
        //for i=0 to r-l do
        //a[l+i] = b[i]; // Копиране обратно
        //}
        int[] array = { 1, 5, 7, 8, 9, 3, 5, 6, 7 ,11,12};
        MergeSort(array, 0, array.GetLength(0) - 1);
        foreach (int item in array)
        {
            Console.WriteLine(item);
        }
    }
    static void MergeSort(int[] tempArray, int left, int right)
    {
        if (left == right)
        {
            return;
        }
        int[] temp = new int[tempArray.GetLength(0)];
        int arrayMiddle = ((left + right) / 2);
        MergeSort(tempArray, left, arrayMiddle);
        MergeSort(tempArray, arrayMiddle + 1, right);
        int j = left;
        int k = arrayMiddle + 1;
        for (int i = 0; i < right - left; i++)
        {
            if (j > arrayMiddle) //(j>m) { b[i] = a[k]; k++;
            {
                temp[i] = tempArray[k];
                k++;
            }
            else if (k > right) //(k>r) { b[i] = a[j]; j++;
            {
                temp[i] = tempArray[j];
                j++;
            }
            else if (tempArray[j] <= tempArray[k]) //(a[j]<=a[k]){ b[i] = a[j]; j++;
            {
                temp[i] = tempArray[j];
                j++;
            }
            else //b[i] = a[k]; k++;
            {
                temp[i] = tempArray[k];
                k++;
            }
        }
        for (int i = 0; i < right - left; i++)
        {
           tempArray[left + i] = temp[i];
        }
    }
}
