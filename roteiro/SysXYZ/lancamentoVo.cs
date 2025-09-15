class LancamentoVo
{
    private int numero_conta;
    private int codigo_agencia;
    private double data_transacao;
    private int codigo_transacao;
    private double valor;

    public LancamentoVo() {}

    public LancamentoVo(LancamentoVo vo)
    {
        this.numero_conta = vo.numero_conta;
        this.codigo_agencia = vo.codigo_agencia;
        this.data_transacao = vo.data_transacao;
        this.codigo_transacao = vo.codigo_transacao;
        this.valor = vo.valor;
    }

    public LancamentoVo(int numero_conta, int codigo_agencia, double data_transacao, int codigo_transacao, double valor)
    {
        this.numero_conta = numero_conta;
        this.codigo_agencia = codigo_agencia;
        this.data_transacao = data_transacao;
        this.codigo_transacao = codigo_transacao;
        this.valor = valor;
    }

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

    public override bool Equals(object? obj)
    {
        if (obj is not LancamentoVo vo)
            return false;
        return (this.numero_conta == vo.numero_conta) && (this.codigo_agencia == vo.codigo_agencia) && (this.data_transacao == vo.data_transacao) && (this.codigo_transacao == vo.codigo_transacao) && (this.valor == vo.valor);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(numero_conta, codigo_agencia, data_transacao, codigo_transacao, valor);
    }
}