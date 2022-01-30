namespace DevFreela.Application.ViewModels
{
    public class SkilViewModel
    {
        public SkilViewModel(int id, string description)
        {
            Id = id;
            Description = description;
        }

        public int Id { get; private set; }
        public string Description { get; private set; }
    }
}
