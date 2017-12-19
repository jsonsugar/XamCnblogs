﻿using XamCnblogs.Portable.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace XamCnblogs.Portable.Interfaces
{
    public interface INewsCommentService
    {
        Task<ResponseMessage> GetCommentAsync(int id,int pageIndex);
        Task<ResponseMessage> PostCommentAsync(int id, string content);
    }
}