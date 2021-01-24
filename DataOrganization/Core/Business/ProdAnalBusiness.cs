namespace DataOrganization.Core.Business
{
    using DataOrganization.Core.Infrastructure.Data;
    using DataOrganization.Core.Infrastructure.DB;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Defines the <see cref="ProdAnalBusiness" />. VIADAO
    /// </summary>
    internal class ProdAnalBusiness
    {
        /// <summary>
        /// The InsertFile.
        /// </summary>
        /// <param name="name">The name<see cref="string"/>.</param>
        /// <returns>The <see cref="int"/>.</returns>
        public int InsertFile(string name)
        {
            ProdAnalData data = new ProdAnalData();
            File file = new File
            {
                Name = name
            };
            return data.InsertFile(file);
        }

        /// <summary>
        /// The InsertField.
        /// </summary>
        /// <param name="idFile">The idFile<see cref="int"/>.</param>
        /// <param name="fieldName">The fieldName<see cref="string"/>.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        public bool InsertField(int idFile, string fieldName)
        {
            ProdAnalData data = new ProdAnalData();
            Field field = new Field
            {
                Field1 = fieldName,
                IdFile = idFile
            };

            return data.InsertField(field);
        }

        /// <summary>
        /// The InsertContent.
        /// </summary>
        /// <param name="idField">The idField<see cref="int"/>.</param>
        /// <param name="contentValue">The contentValue<see cref="string"/>.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        public bool InsertContent(int idField, string contentValue, int line)
        {
            ProdAnalData data = new ProdAnalData();
            Content content = new Content
            {
                FieldContent = contentValue,
                IdField = idField,
                Line = line
            };

            return data.InsertContent(content);
        }

        /// <summary>
        /// The Delete.
        /// </summary>
        /// <param name="idFile">The idFile<see cref="int"/>.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        public bool Delete(int idFile)
        {
            ProdAnalData data = new ProdAnalData();
            return data.Delete(idFile);
        }
        public int[] GetIdFieldsByFile(int idFile)
        {
            ProdAnalData data = new ProdAnalData();
            return data.GetFieldsByFile(idFile);
        }

        public List<Field> GetFieldsByFile(int idFile)
        {
            ProdAnalData data = new ProdAnalData();
            return data.GetIdFieldsByFile(idFile).ToList();
        }

        public List<File> GetAllFields()
        {
            ProdAnalData data = new ProdAnalData();
            return data.GetAllFields();
        }

        public Content GetContentByIdField(int idField, bool orderByCre = false, bool orderByDesc = false, bool withoutZero = false)
        {
            ProdAnalData data = new ProdAnalData();
            List<Content> lstContent = data.GetContentByIdField(idField);

            if (orderByCre)
            {
                if (withoutZero)
                {
                    return lstContent.OrderBy(x => x.FieldContent).FirstOrDefault(x => x.FieldContent != "0");
                }
                return lstContent.OrderBy(x => x.FieldContent).FirstOrDefault();
            }
            if (orderByDesc)
            {
                if (withoutZero)
                {
                    return lstContent.OrderByDescending(x => x.FieldContent).FirstOrDefault(x => x.FieldContent != "0");
                }
            }

            return lstContent.OrderByDescending(x => x.FieldContent).FirstOrDefault();


        }

        public void SaveChanges()
        {
            ProdAnalData data = new ProdAnalData();
            data.SaveChanges();
        }

        public void DeleteAllRegisters()
        {
            ProdAnalData data = new ProdAnalData();
            data.DeleteAllRegisters();
        }
    }
}
