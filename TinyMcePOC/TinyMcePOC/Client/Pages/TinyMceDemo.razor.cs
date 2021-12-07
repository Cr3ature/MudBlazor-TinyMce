namespace TinyMcePOC.Client.Pages
{
    public partial class TinyMceDemo
    {
        private List<SectionDemo>? Sections { get; set; }
        private int Counter;

        protected override Task OnInitializedAsync()
        {
            Sections = new List<SectionDemo>()
            {
                new SectionDemo(){ Id = Guid.NewGuid(), Content = "Content for section 1", Name = "Section 1"},
                new SectionDemo(){ Id = Guid.NewGuid(), Content = "Content for section 2", Name = "Section 2"},
                new SectionDemo(){ Id = Guid.NewGuid(), Content = "Content for section 3", Name = "Section 3"},
                new SectionDemo(){ Id = Guid.NewGuid(), Content = "Content for section 4", Name = "Section 4"},
            };

            Counter = Sections.Count;

            return base.OnInitializedAsync();
        }

        private void AddSection()
        {
            if (Sections == null) Sections = new();

            Counter++;
            Sections.Add(new SectionDemo
            {
                Id = Guid.NewGuid(),
                Name = $"Section {Counter}",
                Content = $"Content for section {Counter}"
            });
            StateHasChanged();
        }

        private void RemoveSection(Guid sectionId)
        {
            if(Sections == null) return;

            Sections.Remove(Sections.First(_ => _.Id == sectionId));
            StateHasChanged();
        }

        private void DoSomething(SectionDemo section)
        {
            Console.WriteLine(section);
        }
    }

    public class SectionDemo
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Content { get; set; }
    }
}