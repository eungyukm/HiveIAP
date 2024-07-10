using System.Text;
using hive;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ProductPurchaseButton : MonoBehaviour
{
    public IAPV4.IAPV4Product Product { get; private set; }
    public HiveMarket market;
    
    public Button button;
    
    public Text productNameText;
    public Text productDescriptionText;
    public Text marketPidText;
    public Text productTypeText;
    public Text displayPriceText;

    public UnityAction<IAPV4.IAPV4Product> OnPurchaseButtonClick;

    public void SetProduct(IAPV4.IAPV4Product product)
    {
        Product = product;
        
        productNameText.text = product.title;
        productDescriptionText.text = product.productDescription;
        marketPidText.text = product.marketPid;
        productTypeText.text = product.productType;
        displayPriceText.text = product.displayPrice;
        
        button.onClick.AddListener(OnButtonClick);
    }

    public void OnButtonClick()
    {
        Purchase(Product);
        OnPurchaseButtonClick.Invoke(Product);
    }
    
    public void Purchase(IAPV4.IAPV4Product product)
    {
        Debug.Log("call IAPV4.purchase");
        IAPV4.purchase(product.marketPid, "", OnPurchase);
    }

    private void OnPurchase(ResultAPI result, IAPV4.IAPV4Receipt receipt)
    {
        if (false == HivePlatform.IsSuccess(result))
        {
            Debug.LogError("IAPV4.purchase failed");
            return;
        }
        
        Debug.Log("IAPV4.purchase success");
        
        var builder = new StringBuilder();
        builder.AppendLine("===============================");
        builder.AppendLine("type: " + receipt.type);
        builder.AppendLine("product: " + receipt.product);
        builder.AppendLine("bypassInfo: " + receipt.bypassInfo);
        builder.AppendLine("hiveiapReceipt: " + receipt.hiveiapReceipt);
        builder.AppendLine("quantity: " + receipt.quantity);
        builder.AppendLine("iapPayload: " + receipt.iapPayload);
        builder.AppendLine("originalJsonObj: " + receipt.originalJsonObj);
        builder.AppendLine("===============================");
        Debug.Log(builder.ToString());

        market.GetRestoreProducts();
    }
}