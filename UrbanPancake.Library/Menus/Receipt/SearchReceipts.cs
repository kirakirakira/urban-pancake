// namespace UrbanPancake.Library
// {
//     public class SearchReceipts : IMenuFunction
//     {
//         public string Choice { get; set; } = "Search for a receipt with a specific item purchased";
//         public int ExecuteChoice()
//         {
//             Console.WriteLine("What item are you looking for?");
//             string? item = Console.ReadLine();

//             ReceiptRepository receiptRepository = new ReceiptRepository();
//             if (item != null)
//             {
//                 Receipt? found = receiptRepository.FindReceiptWithItemPurchased(item);
//                 if (found != null)
//                 {
//                     Console.WriteLine("\n" + found);
//                 }
//                 else
//                 {
//                     Console.WriteLine("There are no receipts with that item");
//                 }

//             }
//             return (int)MenuFunctions.ContinueCurrentMenu;
//         }
//     }
// }
