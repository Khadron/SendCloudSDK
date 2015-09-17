/******************************************************************* 
 * FileName: EmailWebApi.cs
 * Author   : Qiang Kong
 * Date : 2015-09-09 09:52:58
 * Desc : 
 * 
 * 
 * *******************************************************************/
using System;
using CodeScales.Http.Entity;
using CodeScales.Http.Methods;
using SendCloudSDK.Models;
using SendCloudSDK.Utis;
using SendCloudSDK.WebApi.Interface;

namespace SendCloudSDK.WebApi.EMailApi
{
    internal class EmailWebApi : BaseWebApi, IScEmailWebApi
    {
        public EmailWebApi(SendCloudConfig config)
            : base(config)
        {
        }

        public SendResult SendEmail(SendParameter parameter)
        {
            string result = base.CallApi(Config.SendConfig.MailSend, parameter, true);
            return JsonNet.DeserializeToString<SendResult>(result);
        }

        public SendResult SendEmail(SendParameter parameter, string attachmentName, string attachmentPath)
        {
            string result = base.CallApi(Config.SendConfig.MailSend, parameter, attachmentName, attachmentPath);
            return JsonNet.DeserializeToString<SendResult>(result);
        }

        public SendResult SendTemplateEmail(SendTemplateParameter parameter)
        {
            string result = base.CallApi(Config.SendConfig.MailSendTemplate, parameter, true);
            return JsonNet.DeserializeToString<SendResult>(result);
        }

        public SendResult SendTemplateEmail(SendTemplateParameter parameter, string attachmentName, string attachmentPath)
        {
            string result = base.CallApi(Config.SendConfig.MailSendTemplate, parameter, attachmentName, attachmentPath);
            return JsonNet.DeserializeToString<SendResult>(result);
        }

        public TemplateResult GetTemplates()
        {
            string result = base.CallApi(Config.TemplateConfig.TemplateGet, new TemplateGetParameter());
            return JsonNet.DeserializeToString<TemplateResult>(result);
        }

        public TemplateResult GetFirstTemplate(string templateName)
        {
            string result = base.CallApi(Config.TemplateConfig.TemplateGet, new TemplateGetParameter() { InvokeName = templateName });
            return JsonNet.DeserializeToString<TemplateResult>(result);
        }

        public TemplateResult CreateTemplate(TemplateParameter parameter)
        {
            string result = base.CallApi(Config.TemplateConfig.TemplateCreate, parameter);
            return JsonNet.DeserializeToString<TemplateResult>(result);
        }

        public TemplateResult UpdateTemplate(TemplateParameter parameter)
        {
            string result = base.CallApi(Config.TemplateConfig.TemplateUpdate, parameter);
            return JsonNet.DeserializeToString<TemplateResult>(result);
        }

        public TemplateResult DeleteTemplate(DeleteTemplateParameter parameter)
        {
            string result = base.CallApi(Config.TemplateConfig.TemplateDelete, parameter);
            return JsonNet.DeserializeToString<TemplateResult>(result);
        }

        public LabelsResult GetLabels(LabelsParameter parameter)
        {
            string result = base.CallApi(Config.LabelConfig.LabelGetList, parameter);
            return JsonNet.DeserializeToString<LabelsResult>(result);
        }

        public LabelsResult GetLabel(LabelParameter parameter)
        {
            string result = base.CallApi(Config.LabelConfig.LabelGet, parameter);
            return JsonNet.DeserializeToString<LabelsResult>(result);
        }

        public LabelResult CreateLabel(LabelParameter parameter)
        {
            string result = base.CallApi(Config.LabelConfig.LabelCreate, parameter);
            return JsonNet.DeserializeToString<LabelResult>(result);
        }

        public LabelResult UpdateLabel(LabelParameter parameter)
        {
            string result = base.CallApi(Config.LabelConfig.LabelUpdate, parameter);
            return JsonNet.DeserializeToString<LabelResult>(result);
        }

        public LabelResult DeleteLabel(LabelParameter parameter)
        {
            string result = base.CallApi(Config.LabelConfig.LabelDelete, parameter);
            return JsonNet.DeserializeToString<LabelResult>(result);
        }

        public StatsResult GeteByDays(StatsParameter parameter)
        {
            string result = base.CallApi(Config.DataStatisticsConfig.StatiGet, parameter);
            return JsonNet.DeserializeToString<StatsResult>(result);
        }

        public StatsResult GetByHours(StatsParameter parameter)
        {
            string result = base.CallApi(Config.DataStatisticsConfig.StatiGetHour, parameter);
            return JsonNet.DeserializeToString<StatsResult>(result);
        }

        public InvalidStatsResult GetinInvalids(StatsParameter parameter)
        {
            string result = base.CallApi(Config.DataStatisticsConfig.StatiGetInvalid, parameter);
            return JsonNet.DeserializeToString<InvalidStatsResult>(result);
        }

        public UnsubscribesResult GetUnsubscribes(UnsubscribesGetParameter parameter)
        {
            string result = base.CallApi(Config.UnsubscribesConfig.UnsubscribesGet, parameter);
            return JsonNet.DeserializeToString<UnsubscribesResult>(result);
        }

        public UnsubscribesResult CreateUnsubscribe(AddUnsubscribeParameter parameter)
        {
            string result = base.CallApi(Config.UnsubscribesConfig.UnsubscribesCreate, parameter);
            return JsonNet.DeserializeToString<UnsubscribesResult>(result);
        }

        public UnsubscribesResult DeleteUnsubscribe(DelUnsubscribeParameter parameter)
        {
            string result = base.CallApi(Config.UnsubscribesConfig.UnsubscribesDelete, parameter);
            return JsonNet.DeserializeToString<UnsubscribesResult>(result);
        }

    }
}
