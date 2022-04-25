using System;
using System.Collections.Generic;

		// create instance of a new DocumentManager
		var dm = new DocumentManager<int>();

		// add documents to the DocumentManager
		dm.AddDocument(1);
		dm.AddDocument(2);

		dm.IsDocumentAvailable(0);



	public class DocumentManager<TDocument>
		where TDocument : struct
	{
		private readonly List<TDocument> documentList = new List<TDocument>();

		public void AddDocument(TDocument doc)
		{
			lock (this)
			{
				documentList.Add(doc);
			}
		}

		public TDocument IsDocumentAvailable(TDocument doc)

		{

			return documentList[0];

		}
		public void Descending(TDocument doc)
		{

			documentList.Sort();
			documentList.Reverse();

		}




	}
