class LancamentoVo
{
    private int numero_conta;
    private int codigo_agencia;
    private double data_transacao;
    private int codigo_transacao;
    private double valor;

    public int NumeroConta
    {
        get => numero_conta;
        set => numero_conta = value;
    }

    public int CodigoAgencia
    {
        get => codigo_agencia;
        set => codigo_agencia = value;
    }

    public double DataTransacao
    {
        get => data_transacao;
        set => data_transacao = value;
    }

    public int CodigoTransacao
    {
        get => codigo_transacao;
        set => codigo_transacao = value;
    }

    public double Valor
    {
        get => valor;
        set => valor = value;
    }

    public override string ToString()
    {
        return $"{numero_conta};{codigo_agencia};{data_transacao};{codigo_transacao};{valor}";
    }
}