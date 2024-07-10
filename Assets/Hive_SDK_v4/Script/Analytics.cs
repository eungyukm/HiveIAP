/**
 * @file    Analytics.cs
 * 
 *  @date		2016-2022
 *  @copyright	Copyright © Com2uS Platform Corporation. All Right Reserved.
 *  @author		ryuvsken
 *  @since		4.0.0 
 */

using UnityEngine;
using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.IO;

/**
 * @defgroup Analytics
 * @{
 * \~korean  앱과 사용자를 트래킹하고 분석하기 위한 기능 모음<br/>
 * (User Tracking Tool Wrapper & Callect Analytics Log API)<br/><br/>
 * \~english A collection of features for tracking and analyzing apps and users<br/>
 * (User Tracking Tool Wrapper & Callect Analytics Log API)<br/><br/>
 */

 namespace hive
{
	/**
	 * \~korean 앱과 사용자를 트래킹하고 분석하기 위한 기능 모음<br/>
	 * (User Tracking Tool Wrapper & Callect Analytics Log API)<br/><br/>
	 *    
	 * \~english A collection of features for tracking and analyzing apps and users<br/>
	 * (User Tracking Tool Wrapper & Callect Analytics Log API)<br/><br/>
	 * \~
	 * @since		4.0.0 
	 * @author ryuvsken
	 * @ingroup Analytics
	 */
	public class Analytics {

		public static string CONSENT_TYPE_AD_STORAGE = "ad_storage";
    	public static string CONSENT_TYPE_AD_USER_DATA = "ad_user_data";
    	public static string CONSENT_TYPE_AD_PERSONALIZATION = "ad_personalization";
    	public static string CONSENT_TYPE_ANALYTICS_STORAGE = "analytics_storage";
    	public static string CONSENT_GRANTED = "granted";
    	public static string CONSENT_DENIED = "denied";


		/**
		* \~korean
		* [showConsentModeIfRequire], [showConsentMode] 로 동의 배너를 노출할때 커스텀할 수 있는 모델링 객체 입니다.
		*
		* @property title 동의 배너의 상단에 표시되는 문구 입니다.
		* 
		* @property companyName 기본 정보로 노출시 회사이름이 필요한 [title] 과 MainForm 의
		* [ConsentForm.dataUsageDescription] 에 설정됩니다.
		* 
		* @property privacyPolicy 동의 배너 하단의 PrivacyPolicy 버튼을 눌렀을때 동작하는 URL 입니다.
		* 
		* @property mainForm 기본 동의 항목으로 지정되며 [mainForm] 을 동의하지 않으면 다른 항목을 동의할 수 없습니다.
		* 
		* @property formList 개인 정보를 공유할 업체별 동의 항목 입니다.
		*
		* @see [showConsentModeIfRequire], [showConsentMode]
		*/
		public class ConsentMode {

			public string title = "";
			public string companyName = "";
			public string privacyPolicy = "";
			public ConsentForm mainForm = null;
			public List<ConsentForm> formList = new List<ConsentForm>();


			/**
			* \~korean
			* [showConsentModeIfRequire], [showConsentMode] 에서 동의 후 [ConsentModeListener] 로 결과를
			* 받을 수 있습니다. 이때 요청한 [ConsentMode.formList] 에 따른 동의 결과 입니다.
			*
			* @property providerName 동의 대상에 해당하는 Provider 이름입니다. 따로 설정하지 않을 경우 "main",
			* "google", "adjust", "appsflyer", "singular" 중 하나가 설정됩니다.
			* 
			* @property consentForDataUsage 기기정보를 [providerName] 과 공유할지 여부 입니다. 유저의 동의에 따라
			* [Analytics.CONSENT_GRANTED] 혹은 [Analytics.CONSENT_DENIED] 값이 설정 됩니다.
			* 최초로 아무 설정도 하지 않았을 경우 "not-set" 혹은 empty string 이 됩니다.
			
			* @property consentForPersonalization 맞춤 광고 정보를 [providerName] 과 공유할지 여부 입니다. 유저의 동의에 따라
			* [Analytics.CONSENT_GRANTED] 혹은 [Analytics.CONSENT_DENIED] 값이 설정 됩니다.
			* 최초로 아무 설정도 하지 않았을 경우 "not-set" 혹은 empty string 이 됩니다.
			* 
			* @property consentDate 동의를 결정한 시각입니다. 단위는 milli second 입니다.
			* 
			* @property expiredDate 동의가 만료되는 시각입니다. [ConsentForm.retentionPeriod] 설정에 따라
			* [consentDate] 에서 더해진 시각이 됩니다. 단위는 milli second 입니다.
			*
			* @see [ConsentModeListener]
			*/
			public class ConsentStatus {

				public string providerName = "";
				public string consentForDataUsage = "";
				public string consentForPersonalization = "";
				public long consentDate = 0L;
				public long expiredDate = 0L;	

				public JSONObject toJson() {
					JSONObject jsonObject = new JSONObject();

					jsonObject.AddField ("providerName", providerName);
					jsonObject.AddField ("consentForDataUsage", consentForDataUsage);
					jsonObject.AddField ("consentForPersonalization", consentForPersonalization);
					jsonObject.AddField ("consentDate", consentDate);
					jsonObject.AddField ("expiredDate", expiredDate);

					return jsonObject;
				}

				public static ConsentStatus fromJson(JSONObject json) {
					ConsentStatus status = new ConsentStatus();
					json.GetField(ref status.providerName, "providerName");
					json.GetField(ref status.consentForDataUsage, "consentForDataUsage");
					json.GetField(ref status.consentForPersonalization, "consentForPersonalization");
					json.GetField(ref status.consentDate, "consentDate");
					json.GetField(ref status.expiredDate, "expiredDate");

					return status;
				}
			}

			/**
			* \~korean
			* [showConsentModeIfRequire], [showConsentMode] 로 동의 배너를 커스텀하여 노출할 때 사용됩니다.
			*
			* @property providerName 동의 대상에 해당하는 Provider 이름입니다. "main" 으로 설정할 경우
			* [ConsentMode.Builder.setMainForm] 과 동일할 설정이 됩니다.
			* 
			* @property retentionPeriod 동의 후 만료까지의 시간을 설정합니다. 단위는 개월 수 입니다. [providerName] "main" 은 999 입니다.
			* 
			* @property dataUsageTitle 기기정보를 [providerName] 과 공유하는 내용의 타이틀 문구 입니다.
			* 
			* @property dataUsageDescription [dataUsageTitle] 의 세부 내용 입니다.
			* 
			* @property personalizationTitle 맞춤 광고 정보 제공을 동의하는 타이틀 문구 입니다.
			* 
			* @property personalizationDescription [personalizationTitle] 의 세부 내용 입니다.
			*
			* @see [showConsentModeIfRequire], [showConsentMode]
			*/
			public class ConsentForm {

				public string providerName = "";
				public int retentionPeriod = 0;
				public string dataUsageTitle = "";
				public string dataUsageDescription = "";
				public string personalizationTitle = "";
				public string personalizationDescription = "";

				public JSONObject toJson() {
					JSONObject jsonObject = new JSONObject();

					jsonObject.AddField ("providerName", providerName);
					jsonObject.AddField ("retentionPeriod", retentionPeriod);
					jsonObject.AddField ("dataUsageTitle", dataUsageTitle);
					jsonObject.AddField ("dataUsageDescription", dataUsageDescription);
					jsonObject.AddField ("personalizationTitle", personalizationTitle);
					jsonObject.AddField ("personalizationDescription", personalizationDescription);

					return jsonObject;
				}
			}

			public JSONObject toJson() {
				JSONObject jsonObject = new JSONObject();

				jsonObject.AddField ("title", title);
				jsonObject.AddField ("companyName", companyName);
				jsonObject.AddField ("privacyPolicy", privacyPolicy);
				if (mainForm != null) {
					jsonObject.AddField ("mainForm", mainForm.toJson());	
				}
				JSONObject jsonFormArray = new JSONObject();

				foreach (ConsentForm form in formList) {
					jsonFormArray.Add(form.toJson());
				}
				jsonObject.AddField ("formList", jsonFormArray);

				return jsonObject;
			}
		}

		/**
		* \~korean
		* 동의 모드 UI 노출에 따른 응답 리스너입니다.
		* 동의할 경우 성공 콜백과 함께 동의한 결과를 [ConsentMode.ConsentStatus] 배열로 응답합니다.
		* 취소할 경우 [ResultAPI.CANCELED] [ResultAPI.Code.AnalyticsConsentModeCanceled] 로 응답합니다.
		*
		* @see [showConsentModeIfRequire], [showConsentMode]
		*/
		public delegate void ConsentModeListener(ResultAPI result, List<ConsentMode.ConsentStatus> statusList);


		/**
		 * \~korean 분석용 로그 전송.
		 * 
		 * @param logData 로그 데이터
		 * 
		 * @return bool 로그 큐가 가득차 로그를 쌓지 못했을 경우 false를 반환한다.
		 * 
		 * \~english Send log for analysis.
		 * 
		 * @param logData Log data
		 *
		 * @return bool Returns false if the log queue is full and the log is not stacked.
		 *
		 * \~
		 * @ingroup Analytics
		 */
		public static bool sendAnalyticsLog(JSONObject logData) {

			JSONObject jsonParam = HIVEUnityPlugin.createParam("Analytics", "sendAnalyticsLog", null);
			jsonParam.AddField ("logData", logData);

			JSONObject resJsonObject = HIVEUnityPlugin.callNative (jsonParam);

			Boolean isSendAnalyticsLog = false;
			resJsonObject.GetField (ref isSendAnalyticsLog, "sendAnalyticsLog");
			return isSendAnalyticsLog;
		}


		/**
		 * \~korean 사용자 분석을 위한 사용자 정보 트래커 사용 유무 설정
		 * 
		 * @param trackingType 사용자 분석을 위한 사용자 정보 트래커 형태
		 * @param isEnable 트래커 사용 유무
		 * 
		 * \~english Set whether to use User Information Tracker for user analysis
		 * 
		 * @param trackingType User information tracker type
		 * @param isEnable whether to use User Information Tracker 
		 * \~
		 * @ingroup Analytics
		 */
		[System.Obsolete("This is an obsolete method")]
		public static void setEnableTracker(TrackingType trackingType, Boolean isEnable) {

			JSONObject jsonParam = HIVEUnityPlugin.createParam("Analytics", "setEnableTracker", null);
			jsonParam.AddField ("trackingType", trackingType.ToString());
			jsonParam.AddField ("isEnable", isEnable);

			HIVEUnityPlugin.callNative (jsonParam);
		}


		/**
		 * \~korean 사용자 분석을 위한 사용자 정보 트래커 사용 유무 설정
		 * 
		 * @param name 사용자 분석을 위한 사용자 정보 트래커 형태
		 * @param isEnable 트래커 사용 유무
		 * 
		 * \~english Set whether to use User Information Tracker for user analysis
		 * 
		 * @param name User information tracker type
		 * @param isEnable whether to use User Information Tracker 
		 * \~
		 * @ingroup Analytics
		 */
		public static void setEnableTracker(String name, Boolean isEnable) {

			JSONObject jsonParam = HIVEUnityPlugin.createParam("Analytics", "setEnableTrackerWithName", null);
			jsonParam.AddField ("name", name);
			jsonParam.AddField ("isEnable", isEnable);

			HIVEUnityPlugin.callNative (jsonParam);
		}


		/**
		 * \~korean 사용자 분석을 위한 사용자 정보 이벤트 설정
		 * 
		 * @param event	사용자 정보 이벤트
		 * 
		 * \~english Send event for user analysis
		 * 
		 * @param event	Event name
		 * \~
		 * @ingroup Analytics
		 */
		public static void sendEvent(String eventName) {

			JSONObject jsonParam = HIVEUnityPlugin.createParam("Analytics", "sendEvent", null);
			jsonParam.AddField ("eventName", eventName);

			HIVEUnityPlugin.callNative (jsonParam);
		}


		public static void sendTutorialComplete() {

			JSONObject jsonParam = HIVEUnityPlugin.createParam("Analytics", "sendTutorialComplete", null);

			HIVEUnityPlugin.callNative (jsonParam);
		}

		public static uint getRemainAnalyticsLogCount() {
			JSONObject jsonParam = HIVEUnityPlugin.createParam("Analytics", "getRemainAnalyticsLogCount", null);

			JSONObject resJson = HIVEUnityPlugin.callNative (jsonParam);

			uint resultValue = 0;
			resJson.GetField (ref resultValue, "getRemainAnalyticsLogCount");
			return (uint)resultValue;
		}

		/**
		 * \~korean 광고 수익 측정 이벤트 설정
		 * 
		 * @param analyticsAdRevenue	광고 수익 측정 데이터
		 * 
		 * \~english Send events for ad revenue measurement
		 * 
		 * @param analyticsAdRevenue	Ad revenue data
		 * \~
		 * @ingroup Analytics
		 */
		public static void sendAdRevenueEvent(AnalyticsAdRevenue analyticsAdRevenue) {

			JSONObject jsonParam = HIVEUnityPlugin.createParam("Analytics", "sendAdRevenueEvent", null);
			jsonParam.AddField ("analyticsAdRevenue", analyticsAdRevenue.TOJSON());

			HIVEUnityPlugin.callNative (jsonParam);
		}

		/**
		* \~korean
		* @brief 사용자의 퍼널 분석을 위한 지표를 전송한다.
		*
		* 사전정의된 퍼널 목록
		* <table>
		*     <th>
		*         <td>구간명</td><td>퍼널값</td><td>HIVE SDK 자동전송 유무</td>
		*     </th>
		*     <tr>
		*         <td>권한고지</td><td>410</td><td>YES</td>
		*     </tr>
		*     <tr>
		*         <td>고지팝업</td><td>420</td><td>YES</td>
		*     </tr>
		*     <tr>
		*         <td>약관동의</td><td>430</td><td>YES</td>
		*     </tr>
		*     <tr>
		*         <td>게임서버선택</td><td>500</td><td>YES</td>
		*     </tr>
		*     <tr>
		*         <td>서버점검팝업</td><td>600</td><td>YES</td>
		*     </tr>
		*     <tr>
		*         <td>추가다운로드</td><td>700</td><td><b>NO</b></td>
		*     </tr>
		*     <tr>
		*         <td>추가다운로드 완료</td><td>800</td><td><b>NO</b></td>
		*     </tr>
		*     <tr>
		*         <td>로그인</td><td>900</td><td>YES</td>
		*     </tr>
		*     <tr>
		*         <td>전면배너</td><td>1000</td><td>YES</td>
		*     </tr>
		* </table>
		*
		* @param funnelTrack 사전정의된 퍼널의 값
		* @param optionTag 옵션으로 추가 전달할 값
		*/
		public static void sendUserEntryFunnelsLogs(String funnelTrack, String optionTag) {
			JSONObject jsonParam = HIVEUnityPlugin.createParam("Analytics", "sendUserEntryFunnelsLogs", null);
			jsonParam.AddField ("funnelTrack", funnelTrack);
			jsonParam.AddField ("optionTag", optionTag);

			HIVEUnityPlugin.callNative (jsonParam);
		}

		/**
		* \~korean
		* 서드 파티 동의 관리 플랫폼(CMP) 또는 맞춤 솔루션으로 구현한 최종 사용자 동의 상태를 설정한다.
		* Hive Analytics 에서 지원하는 동의 유형은 Analytics.CONSENT_TYPE_AD_STORAGE, Analytics.CONSENT_TYPE_AD_USER_DATA, Analytics.CONSENT_TYPE_AD_PERSONALIZATION, Analytics.CONSENT_TYPE_ANALYTICS_STORAGE 가 있다.
		* 각 유형별로 Analytics.CONSENT_GRANTED, Analytics.CONSENT_DENIED 설정을 할 수 있다.
		* 이 설정은 Firebase Analytics 같은 서드 파티 트래커에 적용된다.
		*
		* @param settings 지원되는 동의 유형 키는 CONSENT_TYPE_AD_STORAGE, CONSENT_TYPE_AD_USER_DATA, CONSENT_TYPE_AD_PERSONALIZATION, CONSENT_TYPE_ANALYTICS_STORAGE. 유효한 값은 CONSENT_GRANTED, CONSENT_DENIED.
		*/
		public static void setConsent(string providerName, Dictionary<string, string> settings) {
			JSONObject jsonParam = HIVEUnityPlugin.createParam("Analytics", "setConsent", null);
		
			jsonParam.AddField ("providerName", providerName);
			string settingsString = new JSONObject(settings).ToString();
			jsonParam.AddField ("settings", settingsString);

			HIVEUnityPlugin.callNative (jsonParam);
		}

		/**
		* \~korean
     	* Analytics.setConsent 으로 설정한 동의 유형별 동의 상태를 반환한다.
    	* 이 값은 Analytics.setConsent 로 설정했던 최근값이다.
    	*/
		public static Dictionary<string, string> getConsent(string providerName) {
			JSONObject jsonParam = HIVEUnityPlugin.createParam("Analytics", "getConsent", null);
			jsonParam.AddField ("providerName", providerName);
			JSONObject resJson = HIVEUnityPlugin.callNative (jsonParam);

			string settingsString = null;
			resJson.GetField (ref settingsString, "settings");

			var dictionary = new Dictionary<string, string>();
			try {
				JSONObject jsonObject = new JSONObject(settingsString);
				dictionary = jsonObject.ToDictionary();
        		
			} catch (System.Exception ignore) {}

			return dictionary;
		}

		/**
		* \~korean
		* 개인 정보를 사용하는 데 최종 사용자 동의를 받기 위한 UI를 노출합니다.
		* 이미 동의를 한 경우 노출되지 않으며 기한이 만료되었거나 추가 동의가 필요한 경우 노출 됩니다.
		* Hive SDK 의 Analytics Provider 추가 여부에 따른 동의 목록을 자동으로 생성합니다.
		* Hive SDK 에서 판단하는 [ConsentMode.ConsentForm.providerName] 은 "main", "google", "adjust", "appsflyer",
		* "singular" 입니다.
		* 서드 파티 동의 관리 플랫폼(CMP) 또는 맞춤 솔루션으로 TCF 규격에 맞게 저장된 파일이 있다면 해당 파일을 읽어
		* 파일에 있는 업체는 동의 설정한 것으로 간주하게 됩니다.
		*
		* @param listener [ConsentModeListener] 로 UI에서 동의한 결과를 [ConsentMode.ConsentStatus] 배열로 응답합니다.
		* 취소할 경우 [ResultAPI.CANCELED] [ResultAPI.Code.AnalyticsConsentModeCanceled] 로 응답합니다.
		*
		* @see [showConsentMode]
		*/
		public static void showConsentModeIfRequire(ConsentModeListener listener) {
			showConsentModeIfRequire(true, null, listener);
		}

		/**
		* \~korean
		* 개인 정보를 사용하는 데 최종 사용자 동의를 받기 위한 UI를 노출합니다.
		* 이미 동의를 한 경우 노출되지 않으며 기한이 만료되었거나 추가 동의가 필요한 경우 노출 됩니다.
		* [consentMode]를 null 로 입력할 경우 Hive SDK 의 Analytics Provider 추가 여부에 따른 동의 목록을 자동으로 생성합니다.
		* Hive SDK 에서 판단하는 [ConsentMode.ConsentForm.providerName] 은 "main", "google", "adjust", "appsflyer",
		* "singular" 입니다.
		*
		* @param checkCmp true 일 경우 서드 파티 동의 관리 플랫폼(CMP) 또는 맞춤 솔루션으로 TCF 규격에 맞게 저장된 파일이 있다면 해당 파일을 읽어
		* 파일에 있는 업체는 동의 설정한 것으로 간주하게 됩니다.
		* @param consentMode UI에 띄울 내용과 Provider를 모두 커스텀 할 수 있게 됩니다.
		* 기본 동의인 [ConsentMode.Builder.setMainForm] 은 [ConsentMode.ConsentForm.providerName] 이 "main" 으로 설정됩니다.
		* @param listener [ConsentModeListener] 로 UI에서 동의한 결과를 [ConsentMode.ConsentStatus] 배열로 응답합니다.
		* 취소할 경우 [ResultAPI.CANCELED] [ResultAPI.Code.AnalyticsConsentModeCanceled] 로 응답합니다.
		*
		* @see [showConsentMode]
		*/
		public static void showConsentModeIfRequire(bool checkCmp, ConsentMode consentMode, ConsentModeListener listener) {
			JSONObject jsonParam = HIVEUnityPlugin.createParam("Analytics", "showConsentModeIfRequire", listener);
			jsonParam.AddField("checkCmp", checkCmp);
			if (consentMode != null) {
				jsonParam.AddField("consentMode", consentMode.toJson());
			}

			HIVEUnityPlugin.callNative (jsonParam);
		}

		/**
		* \~korean
		* 개인 정보를 사용하는 데 최종 사용자 동의를 받기 위한 UI를 노출합니다.
		* 기존에 동의한 내역에 따라 동의 상태값이 설정되어져 있습니다.
		* Hive SDK 의 Analytics Provider 추가 여부에 따른 동의 목록을 자동으로 생성합니다.
		* Hive SDK 에서 판단하는 [ConsentMode.ConsentForm.providerName] 은 "main", "google", "adjust", "appsflyer",
		* "singular" 입니다.
		*
		* @param listener [ConsentModeListener] 로 UI에서 동의한 결과를 [ConsentMode.ConsentStatus] 배열로 응답합니다.
		* 취소할 경우 [ResultAPI.CANCELED] [ResultAPI.Code.AnalyticsConsentModeCanceled] 로 응답합니다.
		*
		* @see [showConsentModeIfRequire]
		*/
		public static void showConsentMode(ConsentModeListener listener) {
			showConsentMode(null, listener);
		}

		/**
		* \~korean
		* 개인 정보를 사용하는 데 최종 사용자 동의를 받기 위한 UI를 노출합니다.
		* 기존에 동의한 내역에 따라 동의 상태값이 설정되어져 있습니다.
		* [consentMode]를 null 로 입력할 경우 Hive SDK 의 Analytics Provider 추가 여부에 따른 동의 목록을 자동으로 생성합니다.
		* Hive SDK 에서 판단하는 [ConsentMode.ConsentForm.providerName] 은 "main", "google", "adjust", "appsflyer",
		* "singular" 입니다.
		*
		* @param consentMode UI에 띄울 내용과 Provider를 모두 커스텀 할 수 있게 됩니다.
		* 기본 동의인 Main 은 [ConsentMode.ConsentForm.providerName] 이 "main" 으로 설정됩니다.
		* @param listener [ConsentModeListener] 로 UI에서 동의한 결과를 [ConsentMode.ConsentStatus] 배열로 응답합니다.
		* 취소할 경우 [ResultAPI.CANCELED] [ResultAPI.Code.AnalyticsConsentModeCanceled] 로 응답합니다.
		*
		* @see [showConsentModeIfRequire]
		*/
		public static void showConsentMode(ConsentMode consentMode, ConsentModeListener listener) {
			JSONObject jsonParam = HIVEUnityPlugin.createParam("Analytics", "showConsentMode", listener);
			if (consentMode != null) {
				jsonParam.AddField("consentMode", consentMode.toJson());
			}

			HIVEUnityPlugin.callNative (jsonParam);
		}




		public static void executeEngine(JSONObject resJsonObject) {

			String methodName = null;
			resJsonObject.GetField (ref methodName, "method");

			int handlerId = -1;
			resJsonObject.GetField (ref handlerId, "handler");
			object handler = (object)HIVEUnityPlugin.popHandler (handlerId);

			if (handler == null) return;

			if ("showConsentModeIfRequire".Equals (methodName)
			|| "showConsentMode".Equals (methodName)

			) {

				List<ConsentMode.ConsentStatus> statusList = new List<ConsentMode.ConsentStatus>();

				JSONObject jsonArray = resJsonObject.GetField ("statusList");
				if (jsonArray != null && jsonArray.count > 0) {
					List<JSONObject> jsonList = jsonArray.list;
					foreach (JSONObject jsonItem in jsonList) {

                        ConsentMode.ConsentStatus status = ConsentMode.ConsentStatus.fromJson(jsonItem);
                        
                        statusList.Add(status);
                    }
				}

				ConsentModeListener listener = (ConsentModeListener)handler;
				listener (new ResultAPI(resJsonObject.GetField ("resultAPI")), statusList);
			}

		}
	}




	/**
	 * \~korean 사용자 분석을 위한 서드 파티 트래커 형태
	 * 
	 * \~english Tracker type for user analysis
	 * \~
	 * @ingroup Analytics
	 * @author ryuvsken
	 */
	[System.Obsolete("This is an obsolete enum")]
	public enum TrackingType {

		ADJUST,
		SINGULAR,
		APPSFLYER,
	};

	public class AnalyticsAdRevenue {
		
		public double revenue = 0.0;                ///< \~korean  광고 노출당 발생하는 광고 수익  \~english Ad impression revenue
		public String adPlatform = "";              ///< \~korean  광고 네트워크 플랫폼 \~english Ad network platform
		public String adUnitId = "";                ///< \~korean 광고 유닛 아이디  \~english Ad Unit Id
		public String adType = "";                  ///< \~korean 광고 노출 타입  \~english  The type of ads
		public String adPlacement = "";             ///< \~korean 광고 노출 위치  \~english ad placement
		public String currency = "USD";             ///< \~korean 통화 코드(ISO_4217 형식 문자열)  \~english ISO_4217 format string (ex. "USD")

		public AnalyticsAdRevenue() {}

		public AnalyticsAdRevenue(double revenue, String adPlatform, String adUnitId, String adType, String adPlacement, String currency) {

			this.revenue = revenue;
			this.adPlatform = adPlatform;
			this.adUnitId = adUnitId;
			this.adType = adType;
			this.adPlacement = adPlacement;
			this.currency = currency;
		}

		public AnalyticsAdRevenue(JSONObject jsonParam) {

			if (jsonParam == null || jsonParam.count <= 0) return;

			jsonParam.GetField (ref this.revenue, "revenue");
			jsonParam.GetField (ref this.adPlatform, "adPlatform");
			jsonParam.GetField (ref this.adUnitId, "adUnitId");
			jsonParam.GetField (ref this.adType, "adType");
			jsonParam.GetField (ref this.adPlacement, "adPlacement");
			jsonParam.GetField (ref this.currency, "currency");
		}

		public String toString() {

			StringBuilder sb = new StringBuilder();

			sb.Append("AnalyticsAdRevenue { revenue = ");
			sb.Append(this.revenue);
			sb.Append(", adPlatform = ");
			sb.Append(this.adPlatform);
			sb.Append(", adUnitId = ");
			sb.Append(this.adUnitId);
			sb.Append(", adType = ");
			sb.Append(this.adType);
			sb.Append(", adPlacement = ");
			sb.Append(this.adPlacement);
			sb.Append(", currency = ");
			sb.Append(this.currency);
			sb.Append(" }\n");

			return sb.ToString();
		}

		public JSONObject TOJSON() {
		
			JSONObject jsonObject = new JSONObject();

			jsonObject.AddField("revenue", this.revenue);
			jsonObject.AddField("adPlatform", this.adPlatform);
			jsonObject.AddField("adUnitId", this.adUnitId);
			jsonObject.AddField("adType", this.adType);
			jsonObject.AddField("adPlacement", this.adPlacement);
			jsonObject.AddField("currency", this.currency);

			return jsonObject;
		}
	}
}


/** @} */



