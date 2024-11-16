using Crazy_Musicians.Models;

namespace Crazy_Musicians.Data
{
    public class MusicianRepository
    {
        private List<Musician> _musicians;

        public MusicianRepository()
        {
            _musicians = new List<Musician>
            {
                new Musician { Id = 1, Name = "John Doe", Instrument = "Guitar", Genre = "Rock", AlbumsCount = 5 },
                new Musician { Id = 2, Name = "Jane Smith", Instrument = "Drums", Genre = "Jazz", AlbumsCount = 3 }
            };
        }

        public List<Musician> GetAllMusicians() => _musicians;

        public Musician GetMusicianById(int id) => _musicians.FirstOrDefault(m => m.Id == id);

        public void AddMusician(Musician musician) => _musicians.Add(musician);

        public void UpdateMusician(Musician musician)
        {
            var existingMusician = _musicians.FirstOrDefault(m => m.Id == musician.Id);
            if (existingMusician != null)
            {
                existingMusician.Name = musician.Name;
                existingMusician.Instrument = musician.Instrument;
                existingMusician.Genre = musician.Genre;
                existingMusician.AlbumsCount = musician.AlbumsCount;
            }
        }

        public void DeleteMusician(int id)
        {
            var musician = _musicians.FirstOrDefault(m => m.Id == id);
            if (musician != null)
            {
                _musicians.Remove(musician);
            }
        }

        public List<Musician> SearchMusicians(string query) => _musicians.Where(m => m.Name.Contains(query)).ToList();
    }
}
