using System;

namespace Jaeger.SAT.CFDI.Cancel {
    public class CancelaResponse {
        private string strCustomerRfcId;
        private string strCustomerName;
        private string strIssueRfcId;
        private string strIssueName;
        private double dblAmount;
        private Acuse objCancelaCfdResult;

        public double Amount {
            get {
                return this.dblAmount;
            }
            set {
                this.dblAmount = value;
            }
        }

        public Acuse CancelaCfdResult {
            get {
                return this.objCancelaCfdResult;
            }
            set {
                this.objCancelaCfdResult = value;
            }
        }

        public string CustomerName {
            get {
                return this.strCustomerName;
            }
            set {
                this.strCustomerName = value;
            }
        }

        public string CustomerRfcId {
            get {
                return this.strCustomerRfcId;
            }
            set {
                this.strCustomerRfcId = value;
            }
        }

        public string IssueName {
            get {
                return this.strIssueName;
            }
            set {
                this.strIssueName = value;
            }
        }

        public string IssueRfcId {
            get {
                return this.strIssueRfcId;
            }
            set {
                this.strIssueRfcId = value;
            }
        }

        public CancelaResponse() {
            this.strCustomerRfcId = string.Empty;
            this.strCustomerName = string.Empty;
            this.strIssueRfcId = string.Empty;
            this.strIssueName = string.Empty;
            this.dblAmount = 0;
        }
    }
}