﻿/*
 * Copyright (c) 2014 TeamViewer GmbH
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 *
 * The above copyright notice and this permission notice shall be included in
 * all copies or substantial portions of the Software.
 *
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
 * THE SOFTWARE.
 *
 * When reusing or redistributing the software please respect any licenses of
 * included software from third parties, if applicable.
 */

namespace TeamViewer_Exporter.Ressources
{
    internal static class TvApiUrls
    {
        public const string UrlCreateSession = "https://webapi.teamviewer.com/api/v1/sessions";

        public const string UrlGetGroupIds = "https://webapi.teamviewer.com/api/v1/groups";

        public const string UrlPing = "https://webapi.teamviewer.com/api/v1/ping";

        public const string UrlToken = "https://webapi.teamviewer.com/api/v1/oauth2/token";

        public const string UrlDevices = "https://webapi.teamviewer.com/api/v1/devices";

        public const string UrlAccount = "https://webapi.teamviewer.com/api/v1/account";

        public const string UrlUsers = "https://webapi.teamviewer.com/api/v1/users?full_list=true";
    }
}