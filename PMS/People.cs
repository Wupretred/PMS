namespace PMS
{
    public class People
    {
        public People(string name, string attr)
        {
            this.name = name;
            this.attr = attr;
        }

        public string name { set; get; }
        public string attr { set; get; }
    }
}