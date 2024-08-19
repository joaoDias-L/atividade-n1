namespace Atividade_H1_1.NovaPasta;

public class CalculareConsultarIMC : Pessoa
{
    public ResultadoIMC IMCCompleto(Pessoa pessoa)
    {

        double imc = pessoa.Peso / (pessoa.Altura * pessoa.Altura);

        string imcFormatado = imc.ToString("F2");

        string descricaoIMC = ConsultarTabelaIMC(Convert.ToDecimal(imcFormatado));

       return new ResultadoIMC
        {
            IMC = imcFormatado,
            Descricao = descricaoIMC
        };
    }
            
    public static string ConsultarTabelaIMC(decimal imc)
    {
        if (imc < 18.5m)
            return "Abaixo do Peso";
        if (imc >= 18.5m && imc < 25)
            return "Peso Ideal";
        if (imc >= 25 && imc < 30)
            return "Sobrepeso";
        if (imc >= 30 && imc < 35)
            return "Obesidade grau 1";
        if (imc >= 35 && imc < 40)
            return "Obesidade grau 2";
        if (imc >= 40)
            return "Obesidade grau 3";

        return "IMC fora do intervalo esperado";
    }
}
