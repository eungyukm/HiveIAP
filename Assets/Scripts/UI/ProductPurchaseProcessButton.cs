using System.Text;
using hive;
using RM2.Login.Structures.Player;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ProductPurchaseProcessButton : MonoBehaviour
{
    public IAPV4.IAPV4Receipt Receipt { get; set; }
    public HiveMarket market;

    public Button button;
    public Text buttonText;

    public void SetReceipt(IAPV4.IAPV4Receipt receipt)
    {
        buttonText.text = receipt.product.marketPid;
        button.onClick.AddListener(OnButtonClick);
    }

    private void OnButtonClick()
    {
        var builder = new StringBuilder();
        builder.AppendLine("verify receipt");
        builder.AppendLine("===============================");
        builder.AppendLine("type: " + Receipt.type);
        builder.AppendLine("product: " + Receipt.product);
        builder.AppendLine("bypassInfo: " + Receipt.bypassInfo);
        builder.AppendLine("hiveiapReceipt: " + Receipt.hiveiapReceipt);
        builder.AppendLine("quantity: " + Receipt.quantity);
        builder.AppendLine("iapPayload: " + Receipt.iapPayload);
        builder.AppendLine("originalJsonObj: " + Receipt.originalJsonObj);
        builder.AppendLine("===============================");


        var body = new VerifyReceiptBody
        {
            WorldId = WebServerContext.WorldId,
            ByPassInfo = Receipt.bypassInfo,
        };

        WebServerClient.VerifyReceipt(body, OnVerifySuccess, OnVerifyFailed);
    }

    private void OnVerifySuccess(VerifyReceiptResponse obj)
    {
        var builder = new StringBuilder();
        builder.AppendLine("verify receipt success");
        builder.AppendLine("===============================");
        builder.AppendLine("result: " + obj.Ok);
        builder.AppendLine("===============================");
        Debug.Log(builder.ToString());

#if false
        if (obj.Ok == 1)
        {
            market.TransactionFinish(Receipt.product);   
        }
#endif
        
        market.GetRestoreProducts();
    }

    private void OnVerifyFailed(WebServerException obj)
    {
        Debug.LogError(obj);
    }
}