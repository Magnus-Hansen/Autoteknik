namespace Autoteknik
{
    public class AutoRepair
    {
		private int _id;
		private DateTime _dateTime;
		private string _description;
		private double _price;
        private static int _countID = 0;
		private List<Mechanics> _mechanics;
		private string _mechanicComment;
		private bool _done;

		public string MechanicComment
		{
			get { return _mechanicComment; }
			set { _mechanicComment = value; }
		}
		public bool Done
		{
			get { return _done; }
			set { _done = value; }
		}
		public double Price
		{
			get { return _price; }
			set { _price = value; }
		}
		public string Description
		{
			get { return _description; }
			set { _description = value; }
		}
		public DateTime DateTime
		{
			get { return _dateTime; }
		}
		public int Id
		{
			get { return _id; }
		}

        public AutoRepair(string description, double price)
        {
			_description = description;
			_price = price;
			_dateTime = DateTime.Now;
			_countID++;
			_id = _countID;
			_done = false;
        }

		public void AddMechanic(Mechanics mechanics)
		{
			_mechanics.Add(mechanics);
		}
		public override string ToString()
		{
			return $"Id: {_id} - DateTime: {_dateTime} - Description: {_description} - Price: {_price}";
		}
    }
}
