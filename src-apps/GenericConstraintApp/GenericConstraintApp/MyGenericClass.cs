namespace GenericConstraintApp
{
    public class MyGenericClass<TEntity, TModel>
        where TEntity : BaseEntity
        where TModel : BaseModel
    {

        public int Add(TEntity entity)
        {

            //todo


            return entity.Id;
        }



    }
}
