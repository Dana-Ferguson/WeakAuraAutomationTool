using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using WeakAuraAutomationTool.LuaMachine;
using WeakAuraAutomationTool.WeakAuras;
using WeakAuraAutomationTool.WeakAuras.Data;
using WeakAuraAutomationTool.WeakAuras.Utility;

namespace WeakAuraAutomationTool
{
    internal static class Tests
    {
        // var test = "!WA:2!1AvwVTX1vyqWeK6bTjsmYSwkjg0cOgjUPgYkwolnPUAKjLKRej1Wrl2DHZ2LCUrdNz89oJ2QBBIAAGAFPnS7lpru0Fa6NGEVahqe0h6tf6H(dW)c65CNHYwkVuuGYh4CNZD7CUFl3PWgLKgV1nN5M3UuVsEL8o6vh6y7UTNikEHOGiX9lwSyZIZCZ5o1js4Xe65DgpMEa)GdSfEvmJIcs4Xgsx7awrNSX5l2VrNoswsHJTdD9JenJ4HjoluTUzvJbzJPf)a2ZFCw7SnRqHcfhKe5Udti5rHxPq7ptSx(6iSDtWyY7yitSfjAoD4HCPVMo(ir7WebVBxCAtDDrEZpDGhZjTthZ9JzILQUsZARVIEc(IHDQWE2dLXSGGL9KANktDy7WctAHJMV3XTxy(wMTBzoVHPEkU4oXb27ZegH29ysnd1qDwIzhK4F2uBky4unA1S6kR0pnmpf0YR0QEDzXJ36rP2cwLAPbbv20NNWojR3Sc8sdeSUybsPRrxruACF7qEpBQOVd8s1oHzlzTseSWUj(VauwpmkKn0dlfAeTPctizUrHEYdPHsRdCd9E28WAWBGtaUb81H3e(g4ZXUyKP5EZwNTRdo9o8UAh3rG1kUz2j2fFsgawJcrlQtRfmQwT(SPCVJ3Ad9v5lEqqRU7LdKlhI1sXNGGnteAhSrgsU6a8GYqvFsTH2Pj4c2iwHNAdOCMN1wpiY27o6i04w2OxkYR0mCdSLYYWhOPlrcd1OVKf0rrOgO3W0SXQRuTMzj337OPnChrAlcVWF9LGVeCPHUi)0lA3Ww7YJzwNm6vct8HxepA1GX1GX0GsV41Hx(OYgyz7UToMKr9jMIc2Ns0kfpAeSdhDIx6wd7YczcUBl)ODBeoqIpMpyx79LWRPbtiwAEJvrkxFfpRoUix55E()LivYO2wqf4AI0qf5bQDkgUTTJms4SAKhZsGjyJWG9TGRgp5c5zCLMIOUcMuw51BrR5BaVIdkf6Ysgkq2yRr7ZjTIsdQOBleCMyiTYNLcwWv0qC)REifL42wXJtnpxLy1NcPofSGjHPGPld3h(oXJtkWDyMzCBkplcV9QpzBglEEcXsmOdgF4BdxcLEs7e6KcpJFNPoAI4sjS9sAl9TXkzRCjD8KQGQ)6ejqUEBzEd4g9pRVP)AY4XEMP)uVItZIoInOp)6MnIFzvqc(iXJ7MCVeF95XxFs2gX3J5Pc(XdZy2pipDor1)hMkt4D2hRbrucM)Myq96nQxfklqsmnMbQb(uQw)8kimjESAc(bvwl12J0ovmnpxHpANgQITlky2uyhF4M5nYsGD4sUtaZkVMFg7Z4XxUE9QgTZi9glV4sMdpBRj30jZROTo3(q9QmbBSU5klxVQJpJ31pzn4BUXPkXfUhETvAohjpSBa7VdFlsNfxIicNFiwW7tDb3v9)115O6fEDYG6m)e0AHmzU5xiYyxmIHDqSVDZNBMB(2ZfFfE3Wibl3wOkjmQkercPLXUeCTM(brr9ka1SGVmDZa6zDCUO8AxRYCWx5nlc3Qiml8wWTp(EDV9I7FWc853zwygnbpKUsbP)VRw8eJCaiK9ECPnEy75dVN2HJ6WcES1rtJJDKhcSGfCVlywCvYSykOkuBwbRxP5GfNcwcwZIKkWMwdrYNRptMjPgkvpwLlPdys7dlx6wWeWkWwwqDlOzMs71uQt4QGbSkzxaMW6WgkvBdO2X4g1aXr7KiX0V)haVc0cEGLdcsgSEw5YumT(3acKi3nvQwuCTPn7QdNxDdAL1vLmMJ4QVeT6y6epHYNaZYLdDJ6HjjDbNfUfVAgliZOXG9Ou882ZIshmfle8pHP1GhsgbW31))zIa89qBIBC0eW3Va8dWxBJAEWsPXbBWbCbpG9XqNcqxen8boo)pe2oZOpa6bHfGiig2b2feGesMeslapY6FmSBq0U1eyAZcD3NyAZoxMqM64eSYwmi3rX6qkejug6KMKef2a5m4n)dOWROU29YhtThPI73D0uVFXLU7FRm97YlD3p3u9ROo1TLAgNPhv7Gp3D7q0gVOAbAP(SjvZv4y4Xv7NE2xrb7rQuy)YWb5As4hEbfi8yI1RNDu8JTGFYAWN4)SIK4RKRsQupkPcI)MkOKKmOtn8JYKFkDZmAO0X5En342VZwBER6gWp1sjR(OcO8a(z56ckY5fgp2k)YZjj9a8PJudnZudiRoJntCBIZtSY6wk(lXJwtrbvS(TSEgkpXA)5erhPQpWc(fJO4xKVr8iIp9u(2fIm2xiY)V4BWVmNJ97TGpZh6d)A43Cz43wa(DzZTm8RG)qb4pve(JfH)84WF5)sioZ6zmL7ZieldS)OZ5igxEeyBW6GFRGpj1jOoNGKBqQaAtZhL(GhM8W3nXLaA0U7t8ZXzKyuANpFR)Zd";
        // var gen = "!WA:2!TFz6xYrv5F8ZTAqcTkK0egtYlKjJhgveIjtsgbeeMEspzgD2s1DwGxq3vx1T7BrQUQk3Q6zZvACzu)DuPDh3BrCfxAe4Nkl6aOIc6xBrFH6l05pH8xGp3Bv9SKC8CCHx5X5fDv1D7z)ZZDyNkNZQxxx7aVMn8lgAzZzDSd8DCJDd8JYoKRZi(8fBhX9QnFGRFCN8ZvQ0CZmDHjk12Y3THLADJMVHLR)e5JxoKN3pWNVg3kIxmwY9RhlUSwQVkrZHlVNttPElLvRvgXvYkQAnxF3iXeyh4Yr2ldVC6XRaVsZOylz8foA3QbshUC8aVa5e5gHL7qSChjtUdZ6wtA1qjvRyRmN3Y3wqlqnKs0vloUzHcZkTS1g2O5jjgp66cxhEzlpVY19cwms02jOSDZO4GgIQjpnWvmkgqGxLa7Xax5MVFEYzWL(wENImd6iNPJKxNEQeMzDzqZWo1A65nUR02JlAxx66CAxNybtM424IrA6609mNk)mUhFfVI1xQBIkRDZvhVWSLky2jXwl6Uc)sn9CB4gZmJST84zQsoUAU1ZM6nMYpIhNPTL0EATpN1QzeFA1geH7KEDSKJMlpjz2IwXs361j9EFdltFD190MwwzY5zFwr(M0QQg6zTmxQoOYQVfDvV56VGkSjwt)rmVrrVGyX6rnRYxG7hxSzTAUl1T84JvSu5ILgZSKmyr)589ww0XHxLMv5FKtwy65N4Kt3kkK75nLtu2WDRoVirWIt5Bh0W1V(KClpX6QrTQgfiRotGdFt5mVKtYXS48fMEAjTOzPWSa7W0IsVgPT(yvdXQsZzYBicZPTolzDESj)CnDLChrNKX8OZt0tl)(7teUl1315(CPRDrsTMZFttwVIw9FJz6t)gLTvFVblCxQSSf4LsCTknN1joWEHKmL9WkFFvtcBIoKbzQZBIYMgSl4uNhURINRPLKp4euk0GNwqhDEValNhmFeLkmGzJMEXUzZt6R9WvJiVLhNHtKTRsfuwxi3HH8jUpTrDwFkmi0HyBpROiHP(Xa0MoFFZkDJIwP7Yo1RPxzzlFNKbLuvPYSOmrnUOxvkLXrge2VImtUdLj3rMpZbpWrZD4mH7XTUFGKpxOUWRGk6vqkdKrI1tm48P7pCN59CxzflPZGLccidmuU8C1Qrj2m5sPV0ZQzmLiNEyzBrzxjql6TynyHTwYPMSHlTQ0YXTzelN9nVAPrScDfWqr16wSjv)i57F)dEut7TP5eljdEzJIl7cjp4kUOrUYlIo1GI2ELJIlhVeRDKNLFSk(BGC4Q2Co5smS3zKX8LIBk5gTQfqLouKLjtwYkmSFm05tN)0sRWKd51WW1YWWzRAt(RYltzA1ixRI247uk9WYtUOGkBrpOd7Tj2Y3lZWCpkMxf7H5WOOkZbLu5l4KcCNvWze4004g04RV9G)aO4lG7qGtj6ztHihkPQ4IustfCxPsCQinHbvV(mOgPFoUr2sEmV8gXNwruIg3NIz4sWq4TQlhA4Qsj2IwkxM1IabHsoLSU5WuKKcOlqKsQCF3JIRElW5)bG6WD3xvvEOJ5gzv1JYYBt)67K4w3xExcNwvWDRlIpr(vccAWG1dCLPrJLi7qLKVD)SmffwXCrfx)ekAsAERij(SeBTKdOMRhFkhdCnDpw9JC8LxzC3XwyKWD7WJSIv9d5tSruuOiwsvOvJTDUBQle3H7mJRVa3BLlCuRLe4nm7WTB6NYXhU32GwDui1X8w0A5imjdx)QxdUHk42f4Me4avt4H4GvWHeyebgtGdJJGJwbJkNCmZzie9AkIQgH4syAvoY4vm1DjqmU5k4nJBb3Afuq0QFN9ChcFC8jWTXWXQOK5oWBb3ywtn2oCVJNglgCEzqDvWDWxxr1P)6Ln91lbXTvIuZu3NmTkfhplMG1LsMU7M(A2QbMkJPLxOWA(l5Gh4nD0Q68lcCVfVA(nIzI8QkmJo6lumMgx2nsDZGKyPaeaHYgsMPZMNGatVVvVMoQ6WYxmKimNEIiHfzrNjLqTTbVJ(yl9ykDq3(BUtwA6PMTq4vPhwvVQUhLT((b5hJ(SxYvb24m3zYc38(bH7AQzNTGz5KBJzo1XNSKQ90XPBXOXWI2BiXWDoH0DLbprtlh1nJgSuP1t0W(xPl)yNS0CjA4Ie6urBAD60x6OUxu(KEvPkvFBQLAkL5ySMEVl4g5s1uvc3R(Zu5ljlRCu6l4YBVXCdDTr90NGW1(S(uIqFRmXZDXxVd7qsnlvljrEQAa3AlJH205QqO7nV6uPlCr)wuDvjwx1R916oj5jQaF(zNB2c61nTlPajRRVlxRBtitqvlZoFImCxINClU7r7ysVRfMXOBG0LsE1fagR1h4OALlWRL1jbdeAflm2cIJaZLnszmQc(nzmPkbSZ2Q)zvb7ktcByj25plNhoMcihBQePy1sqK2ylCpP1mdoBq8Gb(dwsxKtT5WD)stloCwg80n0qdvBm4BGagc19SW52SlfKmezG4kOPQfew4FHgpyXn71GLu9xWY97QaYX923s3d8oe4DYW7sG3ndVN)z7lG7rGwe7h3lEVNaVpnWhVFg(agy1k4dEc8He4dZW)NcBx9yZFQJCJN50hAwt8re4JYWhtrJX9r037Ay0EynYtdyhIyH42ROyPFH9HViH(6rz(2cEucrUxK(XmUrQ7TPqOe(uT77hFo85jOkH6OdIO0BGLtzYFgAsfUD8k4ZsqwYRrm2dGpjXY7k5nMJalwXbYHULBfJIpf(0zvayI(ocnzUJs8Zbi1BV4giYpEJxWPl09eQSbrN6fq7TkXlJBgPf1EyE)jLOjRtj9JjW93Bm9)m1GNu3svR8tY6jPlUxS)fPjhWem8Lu0A8Lti14Riqhb(Qg4by4RPqV4bz4RtO2RJ6o9n2Eo63KHVfdFB8DWdHVl(Em89XpaDf4HXpepcEu8y4)h)ib(Xm8tmWJxbpbLI(KeAbpfd)0laFGFgwJszE69INrGNLHFod)c8lXZXWVIHFndp)9GxGT6RUVmnWdzOLOb6wbpSrc)rv2JhZOVq7vTzCCG)C0nbO)Bj84c8eg4jnWtLbpIHMT0hKn5T9GdO(7Q7BCtEBVyj9Fynd80m8mvWZMrPuVWvJNBxADs5Wg5O45jf1GGm43yGFRINayGFNcEGEm87vyc8Ik(a(dm8h3gmyG(WatEnQBRqfO(FOG)tqbLkDUM3XDgFN3uS9fHcMD7OG9FrOG)Dk3tkI3s5ove(xO650A8BkPE8pRk7)VHsnHUud)1TuKH)2fuyH13UQ)sCbuUfEXZKRroNCrMh(ah8ah5V)d";

        public static void TestUniqueId()
        {
            var a = WeakAuraUniqueId.Generate("hi!");
            var b = WeakAuraUniqueId.Generate("a;lskjfafsddsafads");

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(a == "DwS3xyo)7k");
            Console.WriteLine(b == "JHEvJewzRV");
        }

        public static void RoundTripTest(string compressedString)
        {
            Directory.CreateDirectory("output");

            var wa = new WeakAura(compressedString);

            // var json = wa.ToString();
            var json = compressedString.DecompressToLuaTable().SerializeToString();
            File.WriteAllText("output/json.txt", json);
            Console.WriteLine("Json Generated");

            var code = wa.GenerateCode();
            File.WriteAllText("output/code.cs", code);
            Console.WriteLine("Code Generated");

            var tableClone = wa.ToLuaTable();
            var jsonClone = tableClone.SerializeToString();
            File.WriteAllText("output/jsonClone.txt", jsonClone);
            Console.WriteLine("Json Clone Generated");

            var wa2 = wa.ToCompressedString();
            Console.WriteLine(wa2);
        }

        public static void GenerateCodeTest(string importString)
        {
            var wa = new WeakAura(importString);
            var code = ObjectInitGenerator.ToObjectInitializer(wa.Table);
            Console.WriteLine(code);

            var json = importString.DecompressToLuaTable().SerializeToString();
            File.WriteAllText("output/json.txt", json);
            Console.WriteLine("Json Generated");
        }
    }

    // Code From: https://stackoverflow.com/a/50523916
    // Alternative?: https://github.com/thomasgalliker/ObjectDumper
    internal class ObjectInitGenerator
    {
        public static string ToObjectInitializer(Object obj)
        {
            var sb = new StringBuilder(1024);

            sb.Append("var x = ");
            sb = WalkObject(obj, sb);
            sb.Append(";");

            return sb.ToString();
        }

        private static StringBuilder WalkObject(Object obj, StringBuilder sb)
        {
            if (obj is null)
            {
                sb.Append("null");
                return sb;
            }

            if (obj is Color c)
            {
                sb.Append($"new Color({c.R}, {c.G}, {c.B}, {c.A})");
                return sb;
            }

            var type = obj.GetType();
            var typeName = type.Name;

            var properties = obj.GetType().GetLuaFields();
            var luaArrayProperty = type.GetFields().FirstOrDefault(LuaUtilities.IsLuaArray);
            if (luaArrayProperty != null) properties.Add(luaArrayProperty);

            sb.Append("new " + typeName + " {");

            bool appendComma = false;
            DateTime workDt;
            foreach (var property in properties)
            {
                if (appendComma) sb.Append(", ");
                appendComma = true;

                var pt = property.FieldType;
                var name = pt.Name;

                var isList = pt.GetInterfaces().Contains(typeof(IList));

                var isClass = pt.IsClass;

                if (isList)
                {
                    IList list = (IList)property.GetValue(obj); //, null);
                    var listTypeName = pt.GetGenericArguments()[0].GetFriendlyName(); // DF: was Name -- this might be a bad move

                    if (list != null && list.Count > 0)
                    {
                        sb.Append(property.Name + " = new List<" + listTypeName + ">{");
                        sb = WalkList(list, sb);
                        sb.Append("}");
                    }
                    else
                    {
                        sb.Append(property.Name + " = new List<" + listTypeName + ">()");
                    }
                }
                else if (pt.IsEnum)
                {
                    sb.AppendFormat("{0} = {1}", property.Name, property.GetValue(obj));
                }
                else
                {
                    var value = property.GetValue(obj);
                    var isNullable = pt.IsGenericType && pt.GetGenericTypeDefinition() == typeof(Nullable<>);
                    if (isNullable)
                    {
                        name = pt.GetGenericArguments()[0].Name;
                        if (property.GetValue(obj) == null)
                        {
                            sb.AppendFormat("{0} = null", property.Name);
                            continue;
                        }
                    }

                    switch (name)
                    {
                        case "Int64":
                        case "Int32":
                        case "Int16":
                        case "Double":
                        case "Float":
                            sb.AppendFormat("{0} = {1}", property.Name, value);
                            break;

                        case "Boolean":
                            sb.AppendFormat("{0} = {1}", property.Name, Convert.ToBoolean(value) == true ? "true" : "false");
                            break;

                        case "DateTime":
                            workDt = Convert.ToDateTime(value);
                            sb.AppendFormat("{0} = new DateTime({1},{2},{3},{4},{5},{6})", property.Name, workDt.Year, workDt.Month, workDt.Day, workDt.Hour, workDt.Minute, workDt.Second);
                            break;

                        case "String":
                            sb.AppendFormat("{0} = \"{1}\"", property.Name, value);
                            break;

                        default:
                            // Handles all user classes, should likely have a better way
                            // to detect user class
                            sb.AppendFormat("{0} = ", property.Name);
                            WalkObject(property.GetValue(obj), sb);
                            break;
                    }
                }
            }

            sb.Append("}");

            return sb;
        }

        private static StringBuilder WalkList(IList list, StringBuilder sb)
        {
            bool appendComma = false;
            foreach (object obj in list)
            {
                if (appendComma) sb.Append(", ");
                appendComma = true;
                WalkObject(obj, sb);
            }

            return sb;
        }
    }
}