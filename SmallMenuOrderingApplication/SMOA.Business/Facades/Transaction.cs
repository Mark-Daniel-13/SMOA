using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMOA.Business.Facades
{
    public class Transaction
    {
        public Models.Transaction ToModel(Data.transaction transaction) {
            return new Models.Transaction { 
                TransctionId = transaction.TransactionId,
                Discount = transaction.Discount,
                Tax = transaction.Tax,
                TotalAmount = transaction.TotalAmount,
            };
        }
        public List<Models.Transaction> ToModelList(List<Data.transaction> transactions) {
            var transactionList = new List<Models.Transaction>();
            transactionList = transactions.Select(transaction => new Models.Transaction() {
                TransctionId = transaction.TransactionId,
                Discount = transaction.Discount,
                Tax = transaction.Tax,
                TotalAmount = transaction.TotalAmount,
            }).ToList();
            return transactionList;
        }
        public static bool AddTransaction(Models.Transaction transaction,List<Models.TransactionDetails> transactionDetails)
        {
            try
            {
                using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
                {
                    using (var scope = db.GetTransaction())
                    {

                        var dbTransaction = new Data.transaction()
                        {
                            TransactionId = transaction.TransctionId,
                            Tax = transaction.Tax,
                            Discount = transaction.Discount,
                            TotalAmount = transaction.TotalAmount,
                            CreationDate = DateTime.Now,
                        };
                        db.Save(dbTransaction);

                        transactionDetails.ForEach(transactionDetail =>
                        {
                            var dbTransactionDetail = new Data.transactiondetail()
                            {
                                TransactionDetailId = transactionDetail.TransactionDetailsId,
                                TransactionId = dbTransaction.TransactionId,
                                ProductId = transactionDetail.ProductId,
                                Quantity = transactionDetail.Quantity,
                            };
                            db.Save(dbTransactionDetail);
                        });

                        scope.Complete();
                    }
                    return true;
                }
            }
            catch (Exception msg)
            {
                return false;
            }
        }
    }
}
