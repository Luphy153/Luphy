int num;
int tabuada;
Console.WriteLine("bote um numero para a tabuada");
tabuada = int.Parse(Console.ReadLine());

for (num=1;num<11;num++)
{
    

    Console.WriteLine("{0}X{1}={2}", tabuada,num,tabuada*num);

}

int[] n = new int[10];
for (int m = 0; m < n.Length; m++)
{
    n[m] = m;
    Console.WriteLine("o valor de n[{0}] é: {1}", m, n[m]);
}

