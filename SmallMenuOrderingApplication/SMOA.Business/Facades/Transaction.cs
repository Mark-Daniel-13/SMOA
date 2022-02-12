using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMOA.Business.Facades
{
    public class Transaction
    {
        public static Models.Transaction ToModel(Data.transaction transaction) {
            return new Models.Transaction { 
                TransactionId = transaction.TransactionId,
                Discount = transaction.Discount,
                Tax = transaction.Tax,
                TotalAmount = transaction.TotalAmount,
            };
        }
        public static List<Models.Transaction> ToModelList(List<Data.transaction> transactions) {
            var transactionList = new List<Models.Transaction>();
            transactionList = transactions.Select(transaction => new Models.Transaction() {
                TransactionId = transaction.TransactionId,
                Discount = transaction.Discount,
                Tax = transaction.Tax,
                TotalAmount = transaction.TotalAmount,
            }).ToList();
            return transactionList;
        }
        //Mapping for transctionDetails
        public static List<Models.TransactionDetails> ToModelList(List<Data.transactiondetail> transactiondetails) {
            var transactionDetailsList = new List<Models.TransactionDetails>();
            transactionDetailsList = transactiondetails.Select(detail => new Models.TransactionDetails()
            {
                TransactionDetailsId = detail.TransactionDetailId,
                TransactionId = detail.TransactionId,
                ProductId = detail.ProductId,
                Quantity = detail.Quantity,
            }).ToList();
            return transactionDetailsList;
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
                            TransactionId = transaction.TransactionId,
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
        public static List<Models.Transaction> GetAll()
        {
            using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
            {
                var dbTransactions = db.Fetch<Data.transaction>("WHERE EndDate IS NULL");
                if (dbTransactions == null) return null;

                return ToModelList(dbTransactions);
            }
        }
        public static List<Models.TransactionDetails> GetAllDetailsByTransactionId(int transactionId) {
            using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName)){
                var dbTransactionDetails = db.Fetch<Data.transactiondetail>("Where TransactionId = @0", transactionId);
                if (dbTransactionDetails == null) return null;

                return ToModelList(dbTransactionDetails);
            }
        }
    }
}
