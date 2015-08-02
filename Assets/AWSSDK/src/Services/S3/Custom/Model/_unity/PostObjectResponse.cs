//
// Copyright 2014-2015 Amazon.com, 
// Inc. or its affiliates. All Rights Reserved.
// 
// Licensed under the Amazon Software License (the "License"). 
// You may not use this file except in compliance with the 
// License. A copy of the License is located at
// 
//     http://aws.amazon.com/asl/
// 
// or in the "license" file accompanying this file. This file is 
// distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
// CONDITIONS OF ANY KIND, express or implied. See the License 
// for the specific language governing permissions and 
// limitations under the License.
//

using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Amazon.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Amazon.S3.Model
{
    public class PostObjectResponse : AmazonWebServiceResponse
    {
        public string RequestId { get; set; }
        public string HostId { get; set; }
        
        /// <summary>
        /// Version of the object.
        ///  
        /// </summary>
        public string VersionId {get; set; }
        
        public PostObjectResponse(IWebResponseData response)
        {
            HttpStatusCode = response.StatusCode;
            ContentLength = response.ContentLength;

            if (response.IsHeaderPresent(HeaderKeys.XAmzRequestIdHeader))
                RequestId = response.GetHeaderValue(HeaderKeys.XAmzRequestIdHeader);
            if (response.IsHeaderPresent(HeaderKeys.XAmzId2Header))
                HostId = response.GetHeaderValue(HeaderKeys.XAmzId2Header);
            if (response.IsHeaderPresent(HeaderKeys.XAmzVersionId))
                VersionId = response.GetHeaderValue(HeaderKeys.XAmzVersionId);
        }
    }
}
