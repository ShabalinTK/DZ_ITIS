
void MergeSort(int[] array)
{
    if (array.Length < 2)
        return;

    int mid = array.Length / 2;

    int[] left = new int[mid];

    int[] rigth = new int[array.Length - mid];

    for (int i = 0; i < mid; i++)
        left[i] = array[i];

    for (int i = mid; i < array.Length; i++)
        rigth[i - mid] = array[i];

    MergeSort(left);
    MergeSort(rigth);
    Marge(array, left, rigth);
}

void Marge(int[] arr, int[] arr1, int[] arr2)
{
    int arr1Ind = 0;
    int arr2Ind = 0;
    int arrInd = 0;

    while (arr1Ind < arr1.Length && arr2Ind < arr2.Length)
    {
        if (arr1[arr1Ind] <= arr2[arr2Ind])
        {
            arr[arrInd] = arr1[arr1Ind];
            arr1Ind++;
        }
        else
        {
            arr[arrInd] = arr2[arr2Ind];
            arr2Ind++;
        }
        arrInd++;
    }

    while (arr1Ind < arr1.Length)
    {
        arr[arrInd] = arr1[arr1Ind];
        arr1Ind++;
        arrInd++;
    }

    while (arr2Ind < arr2.Length)
    {
        arr[arrInd] = arr2[arr2Ind];
        arr2Ind++;
        arrInd++;
    }

}

int[] arr = { 1, 23, 95, 213, 12, 42, 73, 15, 7 };

foreach (var item in arr)
    Console.Write(item + " ");

MergeSort(arr);

Console.WriteLine();

foreach (var item in arr)
    Console.Write(item + " ");