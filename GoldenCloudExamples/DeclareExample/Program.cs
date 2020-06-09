using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GoldenCloud.Declare;

namespace GoldenCloudExamples.Declare
{
    class Program
    {
        /// <summary>
        /// 注：要调试该Program中的Main函数时，需把Main1改成Main,并且把其他Program中的Main改为Main1
        /// </summary>
        /// <param name="args"></param>
        static void Main1(string[] args)
        {
            //申报相关接口
            var declareExp = new DeclareExamples();
            declareExp.DeclareInit();//申报初始化
            declareExp.DeclareCancel();//申报作废
            declareExp.DeclarePay();//申报缴款
            declareExp.DeclareQuery();//申报查询
            declareExp.DeclareRegister();//申报登记
            declareExp.DeclareSubmit();//申报提交
        }
    }
}
