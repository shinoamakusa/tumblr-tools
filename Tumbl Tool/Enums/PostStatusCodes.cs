﻿/* 01010011 01101000 01101001 01101110 01101111  01000001 01101101 01100001 01101011 01110101 01110011 01100001
 *
 *  Project: Tumblr Tools - Image parser and downloader from Tumblr blog system
 *
 *  Author: Shino Amakusa
 *
 *  Created: 2013
 *
 *  Last Updated: November, 2015
 *
 * 01010011 01101000 01101001 01101110 01101111  01000001 01101101 01100001 01101011 01110101 01110011 01100001 */

namespace Tumblr_Tool.Enums
{
    /// <summary>
    /// POst Download Status Codes
    /// </summary>
    public enum PostStatusCodes
    {
        /// <summary>
        /// New post
        /// </summary>
        New,

        /// <summary>
        /// Downloaded post
        /// </summary>
        Downloaded,

        /// <summary>
        /// Unabled to download post
        /// </summary>
        UnableToDownload,

        /// <summary>
        /// Ignored post
        /// </summary>
        Ignored
    }
}