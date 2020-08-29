namespace DyamicMenusSample.Models
{
    public class DynMenu
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? ParentMenuId { get; set; }
        public string ControllerName { get; set; }
        public string ActionName { get; set; }
    }
    
}
