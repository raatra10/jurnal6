using System;
namespace modul6_103022300123
{
    public class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> uploadedVideos;
        private string username;

        public SayaTubeUser(string username)
        {
            if (string.IsNullOrEmpty(username))
                throw new ArgumentException("Nama tidak boleh null atau kosong");
            if (username.Length > 50)
                throw new ArgumentException("Nama tidak boleh lebih dari 50 karakter");

            Random rand = new Random();
            this.id = rand.Next(10000, 99999);
            this.username = username;
            this.uploadedVideos = new List<SayaTubeVideo>();
        }

        public int GetTotalVideo()
        {
            int hasil = 0;
            for (int i = 0; i < uploadedVideos.Count; i++)
            {
                hasil += uploadedVideos[i].playCount;
            }
            return hasil;
            }

                public void AddVideo(SayaTubeVideo video)
                {
                    if (video == null)
                        throw new ArgumentNullException("Video tidak boleh null");
                    this.uploadedVideos.Add(video);
                }

                public void PrintAllVideoPlaycount()
                {
                    Console.WriteLine("User: " + this.username);
                    for (int i = 0; i < uploadedVideos.Count; i++)
                    {
                        Console.WriteLine("Video " + (i + 1) + " judul: " + uploadedVideos[i].PrintVideoDetail);
                    }
                }
            }
        }
