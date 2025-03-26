using System;
namespace modul6_103022300123
{
	public class SayaTubeVideo
	{
		private int id;
        private string title;
        private int playCount;
        public SayaTubeVideo(string title)
		{
			if (string.IsNullOrEmpty(title))
				throw new ArgumentException("judul tidak boleh null");
            if (title.Length > 200)
                throw new ArgumentException("judul tidak boleh lebih dari 100 karakter");

			Random rand = new Random();
			this.id = rand.Next(10000, 99999);
			this.title = title;

        }

		public void IncreasePlayCount(int count)
		{
			if (count <= 0)
				throw new ArgumentException("Jumlah play harus lebih dari 0");
            if (count > 25000000)
                throw new ArgumentException("Play count tidak boleh lebih dari 10 juta");
			checked
			{
				this.playCount += count;
			}
        }
		public void PrintVideoDetail()
		{
			Console.WriteLine("ID Video      : " + this.id);
            Console.WriteLine("Judul Video   : " + this.title);
            Console.WriteLine("Jumlah Play   : " + this.playCount);
        }

        internal void PrintVideoDetails()
        {
            throw new NotImplementedException();
        }
    }
}

