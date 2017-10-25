﻿using Base;
using HTTPServerLib;
using PrintServices;

namespace Http.Services.Core
{
    public class PrintController : Controller
    {
        // 打印用工工牌或会员洗码卡
        public Result PrintImage()
        {
            var imgUrl = Request.Params.Get("ImgUrl");
            var printName = Request.Params.Get("PrintName");
            if (string.IsNullOrEmpty(imgUrl))
                return Result.Error("需要打印的图片连接地址有误");

            // posturl : http://127.0.0.1:9191/Print/PrintImage
            // postdata: imgUrl=http://coderoom2.6688jr.com/Views/Login/assets/transfebg/3.jpg&PrintName=xps
            // postdata: imgUrl=http%3A%2F%2Fcoderoom2.6688jr.com%2FViews%2FLogin%2Fassets%2Ftransfebg%2F3.jpg&PrintName=xps
            var printer = new Printer { Logger = this.Logger };

            return printer.PrintImage(imgUrl, printName);
        }

        // 打印HTML文档
        public Result PosPrintHtml()
        {
            // 客户端编码类型 encodeURIComponent ,因为当前系统的参数解码函数是【Uri.UnescapeDataString】
            // posturl : http://127.0.0.1:9191/Print/PosPrintHtml
            // postdata: html=%3Ctable%20style%3D%22margin%3A%2010px%202px%3B%20width%3A%20178px%3B%20border%3A%201px%20solid%20%23000%3B%20font-family%3A%20%E5%AE%8B%E4%BD%93%3B%22%20class%3D%22dl%22%3E%3Ctr%3E%3Ctd%20style%3D%22text-align%3A%20left%3B%20font-size%3A%2012px%3B%20line-height%3A%206px%3B%20height%3A%2040px%3B%20padding%3A5px%3B%22%3E1%202017-10-24%2008%3A25%3A22%3C%2Ftd%3E%3C%2Ftr%3E%3C%2Ftable%3E%3Ctable%20style%3D%22margin%3A%2010px%202px%3B%20width%3A%20178px%3B%20border%3A%201px%20solid%20%23000%3B%20font-family%3A%20%E5%AE%8B%E4%BD%93%3B%22%20class%3D%22dl%22%3E%3Ctr%3E%3Ctd%20style%3D%22text-align%3A%20left%3B%20font-size%3A%2012px%3B%20line-height%3A%206px%3B%20height%3A%2040px%3B%20padding%3A5px%3B%22%3E2%202017-10-24%2008%3A25%3A22%3C%2Ftd%3E%3C%2Ftr%3E%3C%2Ftable%3E%3Ctable%20style%3D%22margin%3A%2010px%202px%3B%20width%3A%20178px%3B%20border%3A%201px%20solid%20%23000%3B%20font-family%3A%20%E5%AE%8B%E4%BD%93%3B%22%20class%3D%22dl%22%3E%3Ctr%3E%3Ctd%20style%3D%22text-align%3A%20left%3B%20font-size%3A%2012px%3B%20line-height%3A%206px%3B%20height%3A%2040px%3B%20padding%3A5px%3B%22%3E3%202017-10-24%2008%3A25%3A22%3C%2Ftd%3E%3C%2Ftr%3E%3C%2Ftable%3E%3Ctable%20style%3D%22margin%3A%2010px%202px%3B%20width%3A%20178px%3B%20border%3A%201px%20solid%20%23000%3B%20font-family%3A%20%E5%AE%8B%E4%BD%93%3B%22%20class%3D%22dl%22%3E%3Ctr%3E%3Ctd%20style%3D%22text-align%3A%20left%3B%20font-size%3A%2012px%3B%20line-height%3A%206px%3B%20height%3A%2040px%3B%20padding%3A5px%3B%22%3E4%202017-10-24%2008%3A25%3A22%3C%2Ftd%3E%3C%2Ftr%3E%3C%2Ftable%3E%3Ctable%20style%3D%22margin%3A%2010px%202px%3B%20width%3A%20178px%3B%20border%3A%201px%20solid%20%23000%3B%20font-family%3A%20%E5%AE%8B%E4%BD%93%3B%22%20class%3D%22dl%22%3E%3Ctr%3E%3Ctd%20style%3D%22text-align%3A%20left%3B%20font-size%3A%2012px%3B%20line-height%3A%206px%3B%20height%3A%2040px%3B%20padding%3A5px%3B%22%3E5%202017-10-24%2008%3A25%3A22%3C%2Ftd%3E%3C%2Ftr%3E%3C%2Ftable%3E%3Ctable%20style%3D%22margin%3A%2010px%202px%3B%20width%3A%20178px%3B%20border%3A%201px%20solid%20%23000%3B%20font-family%3A%20%E5%AE%8B%E4%BD%93%3B%22%20class%3D%22dl%22%3E%3Ctr%3E%3Ctd%20style%3D%22text-align%3A%20left%3B%20font-size%3A%2012px%3B%20line-height%3A%206px%3B%20height%3A%2040px%3B%20padding%3A5px%3B%22%3E6%202017-10-24%2008%3A25%3A22%3C%2Ftd%3E%3C%2Ftr%3E%3C%2Ftable%3E%3Ctable%20style%3D%22margin%3A%2010px%202px%3B%20width%3A%20178px%3B%20border%3A%201px%20solid%20%23000%3B%20font-family%3A%20%E5%AE%8B%E4%BD%93%3B%22%20class%3D%22dl%22%3E%3Ctr%3E%3Ctd%20style%3D%22text-align%3A%20left%3B%20font-size%3A%2012px%3B%20line-height%3A%206px%3B%20height%3A%2040px%3B%20padding%3A5px%3B%22%3E7%202017-10-24%2008%3A25%3A22%3C%2Ftd%3E%3C%2Ftr%3E%3C%2Ftable%3E%3Ctable%20style%3D%22margin%3A%2010px%202px%3B%20width%3A%20178px%3B%20border%3A%201px%20solid%20%23000%3B%20font-family%3A%20%E5%AE%8B%E4%BD%93%3B%22%20class%3D%22dl%22%3E%3Ctr%3E%3Ctd%20style%3D%22text-align%3A%20left%3B%20font-size%3A%2012px%3B%20line-height%3A%206px%3B%20height%3A%2040px%3B%20padding%3A5px%3B%22%3E8%202017-10-24%2008%3A25%3A22%3C%2Ftd%3E%3C%2Ftr%3E%3C%2Ftable%3E%3Ctable%20style%3D%22margin%3A%2010px%202px%3B%20width%3A%20178px%3B%20border%3A%201px%20solid%20%23000%3B%20font-family%3A%20%E5%AE%8B%E4%BD%93%3B%22%20class%3D%22dl%22%3E%3Ctr%3E%3Ctd%20style%3D%22text-align%3A%20left%3B%20font-size%3A%2012px%3B%20line-height%3A%206px%3B%20height%3A%2040px%3B%20padding%3A5px%3B%22%3E9%202017-10-24%2008%3A25%3A22%3C%2Ftd%3E%3C%2Ftr%3E%3C%2Ftable%3E%3Ctable%20style%3D%22margin%3A%2010px%202px%3B%20width%3A%20178px%3B%20border%3A%201px%20solid%20%23000%3B%20font-family%3A%20%E5%AE%8B%E4%BD%93%3B%22%20class%3D%22dl%22%3E%3Ctr%3E%3Ctd%20style%3D%22text-align%3A%20left%3B%20font-size%3A%2012px%3B%20line-height%3A%206px%3B%20height%3A%2040px%3B%20padding%3A5px%3B%22%3E10%202017-10-24%2008%3A25%3A22%3C%2Ftd%3E%3C%2Ftr%3E%3C%2Ftable%3E%3Ctable%20style%3D%22margin%3A%2010px%202px%3B%20width%3A%20178px%3B%20border%3A%201px%20solid%20%23000%3B%20font-family%3A%20%E5%AE%8B%E4%BD%93%3B%22%20class%3D%22dl%22%3E%3Ctr%3E%3Ctd%20style%3D%22text-align%3A%20left%3B%20font-size%3A%2012px%3B%20line-height%3A%206px%3B%20height%3A%2040px%3B%20padding%3A5px%3B%22%3E11%202017-10-24%2008%3A25%3A22%3C%2Ftd%3E%3C%2Ftr%3E%3C%2Ftable%3E%3Ctable%20style%3D%22margin%3A%2010px%202px%3B%20width%3A%20178px%3B%20border%3A%201px%20solid%20%23000%3B%20font-family%3A%20%E5%AE%8B%E4%BD%93%3B%22%20class%3D%22dl%22%3E%3Ctr%3E%3Ctd%20style%3D%22text-align%3A%20left%3B%20font-size%3A%2012px%3B%20line-height%3A%206px%3B%20height%3A%2040px%3B%20padding%3A5px%3B%22%3E12%202017-10-24%2008%3A25%3A22%3C%2Ftd%3E%3C%2Ftr%3E%3C%2Ftable%3E%3Ctable%20style%3D%22margin%3A%2010px%202px%3B%20width%3A%20178px%3B%20border%3A%201px%20solid%20%23000%3B%20font-family%3A%20%E5%AE%8B%E4%BD%93%3B%22%20class%3D%22dl%22%3E%3Ctr%3E%3Ctd%20style%3D%22text-align%3A%20left%3B%20font-size%3A%2012px%3B%20line-height%3A%206px%3B%20height%3A%2040px%3B%20padding%3A5px%3B%22%3E13%202017-10-24%2008%3A25%3A22%3C%2Ftd%3E%3C%2Ftr%3E%3C%2Ftable%3E%3Ctable%20style%3D%22margin%3A%2010px%202px%3B%20width%3A%20178px%3B%20border%3A%201px%20solid%20%23000%3B%20font-family%3A%20%E5%AE%8B%E4%BD%93%3B%22%20class%3D%22dl%22%3E%3Ctr%3E%3Ctd%20style%3D%22text-align%3A%20left%3B%20font-size%3A%2012px%3B%20line-height%3A%206px%3B%20height%3A%2040px%3B%20padding%3A5px%3B%22%3E14%202017-10-24%2008%3A25%3A22%3C%2Ftd%3E%3C%2Ftr%3E%3C%2Ftable%3E%3Ctable%20style%3D%22margin%3A%2010px%202px%3B%20width%3A%20178px%3B%20border%3A%201px%20solid%20%23000%3B%20font-family%3A%20%E5%AE%8B%E4%BD%93%3B%22%20class%3D%22dl%22%3E%3Ctr%3E%3Ctd%20style%3D%22text-align%3A%20left%3B%20font-size%3A%2012px%3B%20line-height%3A%206px%3B%20height%3A%2040px%3B%20padding%3A5px%3B%22%3E15%202017-10-24%2008%3A25%3A22%3C%2Ftd%3E%3C%2Ftr%3E%3C%2Ftable%3E%3Ctable%20style%3D%22margin%3A%2010px%202px%3B%20width%3A%20178px%3B%20border%3A%201px%20solid%20%23000%3B%20font-family%3A%20%E5%AE%8B%E4%BD%93%3B%22%20class%3D%22dl%22%3E%3Ctr%3E%3Ctd%20style%3D%22text-align%3A%20left%3B%20font-size%3A%2012px%3B%20line-height%3A%206px%3B%20height%3A%2040px%3B%20padding%3A5px%3B%22%3E16%202017-10-24%2008%3A25%3A22%3C%2Ftd%3E%3C%2Ftr%3E%3C%2Ftable%3E%3Ctable%20style%3D%22margin%3A%2010px%202px%3B%20width%3A%20178px%3B%20border%3A%201px%20solid%20%23000%3B%20font-family%3A%20%E5%AE%8B%E4%BD%93%3B%22%20class%3D%22dl%22%3E%3Ctr%3E%3Ctd%20style%3D%22text-align%3A%20left%3B%20font-size%3A%2012px%3B%20line-height%3A%206px%3B%20height%3A%2040px%3B%20padding%3A5px%3B%22%3E17%202017-10-24%2008%3A25%3A22%3C%2Ftd%3E%3C%2Ftr%3E%3C%2Ftable%3E%3Ctable%20style%3D%22margin%3A%2010px%202px%3B%20width%3A%20178px%3B%20border%3A%201px%20solid%20%23000%3B%20font-family%3A%20%E5%AE%8B%E4%BD%93%3B%22%20class%3D%22dl%22%3E%3Ctr%3E%3Ctd%20style%3D%22text-align%3A%20left%3B%20font-size%3A%2012px%3B%20line-height%3A%206px%3B%20height%3A%2040px%3B%20padding%3A5px%3B%22%3E18%202017-10-24%2008%3A25%3A22%3C%2Ftd%3E%3C%2Ftr%3E%3C%2Ftable%3E%3Ctable%20style%3D%22margin%3A%2010px%202px%3B%20width%3A%20178px%3B%20border%3A%201px%20solid%20%23000%3B%20font-family%3A%20%E5%AE%8B%E4%BD%93%3B%22%20class%3D%22dl%22%3E%3Ctr%3E%3Ctd%20style%3D%22text-align%3A%20left%3B%20font-size%3A%2012px%3B%20line-height%3A%206px%3B%20height%3A%2040px%3B%20padding%3A5px%3B%22%3E19%202017-10-24%2008%3A25%3A22%3C%2Ftd%3E%3C%2Ftr%3E%3C%2Ftable%3E%3Ctable%20style%3D%22margin%3A%2010px%202px%3B%20width%3A%20178px%3B%20border%3A%201px%20solid%20%23000%3B%20font-family%3A%20%E5%AE%8B%E4%BD%93%3B%22%20class%3D%22dl%22%3E%3Ctr%3E%3Ctd%20style%3D%22text-align%3A%20left%3B%20font-size%3A%2012px%3B%20line-height%3A%206px%3B%20height%3A%2040px%3B%20padding%3A5px%3B%22%3E20%202017-10-24%2008%3A25%3A22%3C%2Ftd%3E%3C%2Ftr%3E%3C%2Ftable%3E%3Cdiv%20style%3D%22margin-top%3A%2060px%3B%22%3E.%3C%2Fdiv%3E&PrintName=5860
            var html = Request.Params.Get("Html");
            if (string.IsNullOrEmpty(html))
                return Result.Error("打印内容不能为空");

            var printName = Request.Params.Get("PrintName");
            var printer = new Printer { Logger = this.Logger };

            return printer.PosPrintHtml(html, printName);
        }
    }
}