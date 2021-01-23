namespace DataOrganization.Core.Infrastructure.Data
{
    using DataOrganization.Core.Infrastructure.DB;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Defines the <see cref="ProdAnalData" />.
    /// </summary>
    internal class ProdAnalData
    {
        /// <summary>
        /// Defines the dbContext.
        /// </summary>
        private readonly ProdDataEntities dbContext = new ProdDataEntities();

        /// <summary>
        /// The InsertFile.
        /// </summary>
        /// <param name="file">The file<see cref="File"/>.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        public int InsertFile(File file)
        {
            try
            {
                dbContext.Files.Add(file);
                SaveChanges();

                return dbContext.Files.Max(x => x.Id);
            }
            catch (Exception ex)
            {
                return -99;
            }
        }

        /// <summary>
        /// The InsertField.
        /// </summary>
        /// <param name="field">The field<see cref="Field"/>.</param>
        /// <returns>The <see cref="int"/>.</returns>
        public bool InsertField(Field field)
        {
            try
            {
                dbContext.Fields.Add(field);
                 SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        /// <summary>
        /// The InsertContent.
        /// </summary>
        /// <param name="content">The content<see cref="Content"/>.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        public bool InsertContent(Content content)
        {
            try
            {
                dbContext.Contents.Add(content);
                 SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        /// <summary>
        /// The Delete.
        /// </summary>
        /// <param name="idFile">The idFile<see cref="int"/>.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        public bool Delete(int idFile)
        {
            try
            {
                //get all data
                File file = dbContext.Files.FirstOrDefault(x => x.Id == idFile);
                List<Field> field = dbContext.Fields.Where(x => x.IdFile == file.Id).ToList();
                List<Content> content = dbContext.Contents.Where(x => field.Contains(x.Field)).ToList();

                //delete
                dbContext.Contents.RemoveRange(content);
                dbContext.Fields.RemoveRange(field);
                dbContext.Files.Remove(file);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public int[] GetFieldsByFile(int idFile)
        {
            return dbContext.Fields.Where(x => x.IdFile == idFile).Select(x=>x.Id).ToArray();
        }

        public IEnumerable<Field> GetIdFieldsByFile(int idFile)
        {
            return dbContext.Fields.Where(x => x.IdFile == idFile);
        }
        public void SaveChanges()
        {
            dbContext.SaveChanges();
        }

        public List<File> GetAllFields()
        {
            return dbContext.Files.ToList();
        }

        public Content GetContentByIdField(int idField)
        {
            return dbContext.Contents.Where(x=>x.IdField==idField).OrderBy(x=>x.FieldContent).FirstOrDefault();
        }
    }
}
