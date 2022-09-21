namespace ClothingStore.Models
{
    public interface ISneakersRepository
    {
        IEnumerable<Sneakers> AllSneakers { get; }
        IEnumerable<Sneakers> IsSneakersofTheWeek { get; }
        Sneakers? GetSneakersById(int SneakersId);
    }
}
