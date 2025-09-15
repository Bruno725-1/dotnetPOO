using System;
using System.IO;
using System.Text;
class Program
{
    public static void Main(string[] args)
    {
        string[] valores;
        LancamentoDao ld = new LancamentoDao(30);
        StreamReader leitor = new StreamReader("entration.txt", Encoding.UTF8);
        string linha;
        while ((linha = leitor.ReadLine()) != null)
        {
            valores = linha.Split(';');
            LancamentoVo lv = new LancamentoVo(int.Parse(valores[0]), int.Parse(valores[1]), double.Parse(valores[2]), int.Parse(valores[3]), double.Parse(valores[4]));
            ld.Incluir(lv);
        }
        leitor.Close();
        ld.CarregarNovoArquivo();
        CListaVet<LancamentoVo> lista = ld.ObterTodos;
        for (int i = 0; i < 5; i++)
            Console.WriteLine(lista[i]);
    }
}