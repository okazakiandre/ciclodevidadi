namespace CicloDeVidaDI.Dtos
{
    public struct ContagemDto
    {
        public int TotalSingleton { get; set; }
        public int TotalScoped { get; set; }
        public int TotalTransient { get; set; }
    }
}
