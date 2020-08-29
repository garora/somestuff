using LearningSolid.Liskov;

namespace LearningSolid.InterfaceSegregationPrinciple
{
    public interface IReport:IRepository
    {
        void Generate();
    }
}
