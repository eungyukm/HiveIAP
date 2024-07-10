using System.Collections;
using System.Collections.Generic;
using System.Text;
using hive;
using UnityEngine;

public class HiveMarket : MonoBehaviour
{
    public Transform marketProductPrefabParent;
    public GameObject marketProductPrefab;
    public Transform marketRestorePrefabParent;
    public GameObject marketRestorePrefab;
    
    public void MarketConnect()
    {
        Debug.Log("call IAPV4.marketConnect");
        IAPV4.marketConnect(OnMarketConnect);
    }

    private void OnMarketConnect(ResultAPI result, List<IAPV4.IAPV4Type> iapV4Types)
    {
        if (false == HivePlatform.IsSuccess(result))
        {
            Debug.LogError("IAPV4.marketConnect failed");
            return;
        }
        
        Debug.Log("IAPV4.marketConnect success");
        GetRestoreProducts();
        GetProductInfo();
    }

    public void GetProductInfo()
    {
        Debug.Log("call IAPV4.getProductInfo");
        IAPV4.getProductInfo(OnGetProductInfo);
    }

    private void OnGetProductInfo(ResultAPI result, List<IAPV4.IAPV4Product> iapV4Products, int balance)
    {
        if (false == HivePlatform.IsSuccess(result))
        {
            Debug.LogError("IAPV4.getProductInfo failed");
            return;
        }
        
        Debug.Log("IAPV4.getProductInfo success");
        Debug.Log("balance: " + balance);
        
        ClearProducts();
        foreach (var product in iapV4Products)
        {
            CreateProductObject(product);
        }
        
        GameManager.Inst.ForceUpdateCanvas();
    }

    // 미지급된 아이템의 영수증 정보 요청
    public void GetRestoreProducts()
    {
        Debug.Log("call IAPV4.restore");
        IAPV4.restore(OnRestore);
    }

    private void OnRestore(ResultAPI result, List<IAPV4.IAPV4Receipt> receipts)
    {
        if (false == HivePlatform.IsSuccess(result))
        {
            Debug.LogError("IAPV4.restore failed");
            return;
        }
        
        Debug.Log("IAPV4.restore success");
        var builder = new StringBuilder();
        foreach (var receipt in receipts)
        {
            builder.AppendLine("===============================");
            builder.AppendLine("type: " + receipt.type);
            builder.AppendLine("product: " + receipt.product);
            builder.AppendLine("bypassInfo: " + receipt.bypassInfo);
            builder.AppendLine("hiveiapReceipt: " + receipt.hiveiapReceipt);
            builder.AppendLine("quantity: " + receipt.quantity);
            builder.AppendLine("iapPayload: " + receipt.iapPayload);
            builder.AppendLine("originalJsonObj: " + receipt.originalJsonObj);
            builder.AppendLine("===============================");
        }
        Debug.Log(builder.ToString());

        ClearRestoreProducts();
        foreach (var receipt in receipts)
        {
            CreateRestoreProductObject(receipt);
        }

        GameManager.Inst.ForceUpdateCanvas();
    }

    public void TransactionFinish(IAPV4.IAPV4Product product)
    {
        Debug.Log("call IAPV4.transactionFinish");
        IAPV4.transactionFinish(product.marketPid, OnTransactionFinish);
    }

    private void OnTransactionFinish(ResultAPI result, string marketPid)
    {
        if (false == HivePlatform.IsSuccess(result))
        {
            Debug.LogError("IAPV4.transactionFinish failed");
            return;
        }
        
        Debug.Log("IAPV4.transactionFinish success");
        Debug.Log("marketPid: " + marketPid);
    }

    private void ClearProducts()
    {
        foreach (Transform child in marketProductPrefabParent) {
            Destroy(child.gameObject);
        }
    }

    private void CreateProductObject(IAPV4.IAPV4Product product)
    {
        var productObject = Instantiate(marketProductPrefab, marketProductPrefabParent);
        var marketProduct = productObject.GetComponent<ProductPurchaseButton>();
        marketProduct.SetProduct(product);
        marketProduct.market = this;
    }
    
    private void ClearRestoreProducts()
    {
        foreach (Transform child in marketRestorePrefabParent) {
            Destroy(child.gameObject);
        }
    }
    
    private void CreateRestoreProductObject(IAPV4.IAPV4Receipt receipt)
    {
        var productObject = Instantiate(marketRestorePrefab, marketRestorePrefabParent);
        var marketRestoreProduct = productObject.GetComponent<ProductPurchaseProcessButton>();
        marketRestoreProduct.SetReceipt(receipt);
    }
}