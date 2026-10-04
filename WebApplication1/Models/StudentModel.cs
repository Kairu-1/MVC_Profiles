namespace WebApplication1.Models
{
    public class StudentModel
    {
        private int _id;

        public int id 
        { 
            get
            {
                return _id;
            }
            set
            {
                if (value >0)
                {
                    _id = value;
                }
                else
                {
                    throw new Exception("Wrong input in ID field");
                }
            }
        }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string address { get; set; }
        public string contactNum { get; set; }
        public DateOnly dateofBirth { get; set; }
    }
}
