

namespace DAL
{
    using DAL.Models;


    public abstract class RepositoryBase
    {
        
        protected RepositoryBase()
        {
        }

        protected LearnByPracticeDataContext CreateContext()
        {
            LearnByPracticeDataContext context = new LearnByPracticeDataContext();
            context.DeferredLoadingEnabled = false;

            return context;
        }
    }
}
