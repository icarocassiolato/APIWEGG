namespace Domain.Entities
{
    public class Imovel
    {
        public int IdImovel { get; set; }
        public int? CadastroImobiliario { get; set; }
        public string? Descricao { get; set; }
        public decimal? Valor { get; set; }
        public decimal? Latitude { get; set; }
        public decimal? Longitude { get; set; }
        public string? CaminhoMatricula { get; set; }

        public Imovel(int IdImovel, int? CadastroImobiliario, string? Descricao, decimal? Valor, decimal? Latitude, decimal? Longitude, string? CaminhoMatricula)
        {
            this.IdImovel = IdImovel;
            this.CadastroImobiliario = CadastroImobiliario;
            this.Descricao = Descricao;
            this.Valor = Valor;
            this.Latitude = Latitude;
            this.Longitude = Longitude;
            this.CaminhoMatricula = CaminhoMatricula;
        }
    }
}
