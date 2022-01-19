// See https://aka.ms/new-console-template for more information
int[] price = { 3,1, 5, 2, 3, 7, 6, 4, 5 };
Console.WriteLine(findMaxProfit(price));


 static int findMaxProfit(int[] price)
{
    int left = 0;
    int profit = 0;
    int TotalProf = 0;

    for (int right = 0; right < price.Length-1; right++)
    {
        while (right+1< price.Length && price[right+1]>price[right])
        {
            right++;
            profit = price[right] - price[left];
        }
        left = right+1;
        TotalProf += profit;
        profit = 0;
    }

    return TotalProf;
}