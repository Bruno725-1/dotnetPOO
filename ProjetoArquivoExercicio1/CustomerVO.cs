namespace ProjetoArquivoExercicio1;
class CustomerVO
{
    private int index;
    private string customer_id;
    private string first_name;
    public CustomerVO(string[] dadosCustomer)
    {
        index = int.Parse(dadosCustomer[0]);
        customer_id = dadosCustomer[1];
        first_name = dadosCustomer[2];
    }

    public override string ToString()
    {
        return $"{index} {customer_id} {first_name}";
    }
}