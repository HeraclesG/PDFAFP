﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Diagnostics;
using PdfSharp.Pdf.Advanced;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using System.Drawing.Imaging;
using PdfSharp.Drawing;
using System.Collections;
using System.Xml.Linq;
using System.IO;
using System.Reflection;
using System.IO;

namespace pdfafp
{
    public class PDFTOAFP
    {
        public static void CovertAFP(string pdfFilePath)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            byte[] afpData = CreateAFPData();
            
            File.WriteAllBytes("output.afp", afpData);
        }
        public static void ExtractTextElements(string pdfFilePath)
        {
            /*using (PdfDocument document = PdfReader.Open(pdfFilePath, PdfDocumentOpenMode.Import))
            {
                // Process the pages of the document
                for (int pageIndex = 0; pageIndex < document.PageCount; pageIndex++)
                {
                    PdfPage page = document.Pages[pageIndex];
                    // Process the text elements on the page
                    ExtractTextElements(page);
                }
            }*/
            Debug.WriteLine("Extractg Texts");
            string text = PDFTextExtractor.PdfToText(pdfFilePath);
            Debug.WriteLine(text);
        }
        private static void ExtractTextElements(PdfPage page)
        {
            // Get the content stream of the page
            /*PdfContentStream contentStream = page.Contents.CreateFormXObject();

            // Loop through the text elements in the content stream
            foreach (XGraphics gfx in contentStream.GraphicsStates)
            {
                // Get the text element
                PdfTextElement textElement = gfx.CurrentContent as PdfTextElement;
                if (textElement != null)
                {
                    // Extract the text, position, color, and font information
                    string text = textElement.Text;
                    double x = textElement.Position.X;
                    double y = textElement.Position.Y;
                    PdfColor color = textElement.Color;
                    PdfFont font = textElement.Font;

                    // Print the extracted information
                    Console.WriteLine($"Text: {text}, Position: ({x}, {y}), Color: {color}, Font: {font.Name}");
                }
            }*/
        }
        public static byte[] CreateAFPData()
        {
            using (MemoryStream ms = new MemoryStream())
            {
                _BeginResourceGroup(ms, "D3A8C6");

                _BeginFontResource(ms, "D3A8CE", "T1001252", 65);
                _ReadExternalResource(ms, "T1001252");
                _EndResource(ms, "D3A9CE");

                _BeginFontResource(ms, "D3A8CE", "CZ000001", 64);
                _ReadExternalResource(ms, "CZ000001");
                _EndResource(ms, "D3A9CE");

                _BeginFontResource(ms, "D3A8CE", "XZ000001", 66);
                _ReadExternalResource(ms, "XZ000001");
                _EndResource(ms, "D3A9CE");

                _BeginFontResource(ms, "D3A8CE", "CZ000002", 64);
                _ReadExternalResource(ms, "CZ000002");
                _EndResource(ms, "D3A9CE");

                _BeginFontResource(ms, "D3A8CE", "XZ000002", 66);
                _ReadExternalResource(ms, "XZ000002");
                _EndResource(ms, "D3A9CE");

                _BeginFontResource(ms, "D3A8CE", "CZ000003", 64);
                _ReadExternalResource(ms, "CZ000003");
                _EndResource(ms, "D3A9CE");

                _BeginFontResource(ms, "D3A8CE", "XZ000003", 66);
                _ReadExternalResource(ms, "XZ000003");
                _EndResource(ms, "D3A9CE");

                _BeginFontResource(ms, "D3A8CE", "CZ000004", 64);
                _ReadExternalResource(ms, "CZ000004");
                _EndResource(ms, "D3A9CE");

                _BeginFontResource(ms, "D3A8CE", "XZ000004", 66);
                _ReadExternalResource(ms, "XZ000004");
                _EndResource(ms, "D3A9CE");

                _BeginResourceImage(ms, "D3A8CE", "I0000001");
                _ObjectClassification(ms, "10", "06072B12000401011700000000000000");
                _BeginObjectContatiner(ms, "D3A892", "I0000001");
                _ObjectContainerData(ms, "D3EE92", "IM000002");
                _EndObjectContainer(ms, "D3A992");
                _EndImageResource(ms, "D3A9CE", "I0000001");

                _BeginResourceImage(ms, "D3A8CE", "I0000002");
                _ObjectClassification(ms, "10", "06072B12000401011700000000000000");
                _BeginObjectContatiner(ms, "D3A892", "I0000002");
                _ObjectContainerData(ms, "D3EE92", "IM000001");
                _EndObjectContainer(ms, "D3A992");
                _EndImageResource(ms, "D3A9CE", "I0000001");

                _BeginResourceImage(ms, "D3A8CE", "I0000003");
                _ObjectClassification(ms, "10", "06072B12000401011700000000000000");
                _BeginObjectContatiner(ms, "D3A892", "I0000003");
                _ObjectContainerData(ms, "D3EE92", "IM000000");
                _EndObjectContainer(ms, "D3A992");
                _EndImageResource(ms, "D3A9CE", "I0000001");

                _EndResourceGroup(ms, "D3A9C6");

                _BeginDocument(ms, "D3A8A8", "(/,Á ã&", "00", "UTF-8");

                _BeginPage(ms, "D3A8AF");
                _BeginActiveEnvirommentGroup(ms, "D3A8C9");
                _MCF(ms, 312, "D3AB8A");
                _PageDescriptor(ms, "D3A6AF", 0, 0, 14400, 14400, 11906, 16838, 0);
                _EndActiveEnvirommentGroup(ms, "D3A9C9");

                _IncludeObject(ms, "D3AFC3", "I0000001", 146, 283, 172, 0, 11520, 0, 0, 1);
                _MeasureUnit(ms, "4B", 0, 0, 3000, 3000);
                _ObjectAreaSize(ms, "4C", 2, 787, 470);
                _MappingOption(ms, "04", 96);
                _ObjectClassification(ms, "10", "06072B12000401011700000000000000");

                _IncludeObject(ms, "D3AFC3", "I0000002", 146, 355, 6393, 0, 11520, 0, 0, 1);
                _MeasureUnit(ms, "4B", 0, 0, 3000, 3000);
                _ObjectAreaSize(ms, "4C", 2, 433, 345);
                _MappingOption(ms, "04", 96);
                _ObjectClassification(ms, "10", "06072B12000401011700000000000000");

                _IncludeObject(ms, "D3AFC3", "I0000003", 146, 6177, 6350, 0, 11520, 0, 0, 1);
                _MeasureUnit(ms, "4B", 0, 0, 3000, 3000);
                _ObjectAreaSize(ms, "4C", 2, 433, 412);
                _MappingOption(ms, "04", 96);
                _ObjectClassification(ms, "10", "06072B12000401011700000000000000");

                _ReadExternalResource(ms, "DZ000001");
                _ReadExternalResource(ms, "DZ000002");

                _BeginPresentationText(ms, "D3A89B");
                _PresentationTextData(ms, "D3EE9B");
                _EndPresentationText(ms, "D3A99B");
                _EndPage(ms, "D3A9AF");

                _EndDocument(ms, "D3A9A8", "UTF-8");
                return ms.ToArray();
            }
        }
        public static void _IncludeObject(MemoryStream ms, string id, string rsname, short objType, short xoaoset,
            short yoaoset, short xoaorent, short yoaorent, short xocaoset, short yocaoset, byte refcsys)
        {
            _WriteSegStarter(ms);
            _WriteSegSize(ms, 79);
            _WriteIDSeg(ms, id);
            _WriteStaticValue(ms, "000002");
            _WriteRSName(ms, rsname);
            _WriteShortValue(ms, objType);
            _WriteStaticValue(ms, "00");
            _WriteShortValue(ms, xoaoset);
            _WriteStaticValue(ms, "00");
            _WriteShortValue(ms, yoaoset);
            _WriteShortValue(ms, xoaorent);
            _WriteShortValue(ms, yoaorent);
            _WriteStaticValue(ms, "00");
            _WriteShortValue(ms, xocaoset);
            _WriteStaticValue(ms, "00");
            _WriteShortValue(ms, yocaoset);
            _WriteByteValue(ms, refcsys);
        }
        public static void _MeasureUnit(MemoryStream ms, string id, byte xoabase, byte yoabase, short xoaunits, short yoaunits)
        {
            _WriteSegSizeByte(ms, 8);
            _WriteIDSeg(ms, id);
            _WriteByteValue(ms, xoabase);
            _WriteByteValue(ms, yoabase);
            _WriteShortValue(ms, xoaunits);
            _WriteShortValue(ms, yoaunits);
        }
        public static void _ObjectAreaSize(MemoryStream ms, string id, byte sizetype, short xoasize, short yoasize)
        {
            _WriteSegSizeByte(ms, 9);
            _WriteIDSeg(ms, id);
            _WriteByteValue(ms, sizetype);
            _WriteStaticValue(ms, "00");
            _WriteShortValue(ms, xoasize);
            _WriteStaticValue(ms, "00");
            _WriteShortValue(ms, yoasize);
        }
        public static void _MappingOption(MemoryStream ms, string id, byte mapvalue)
        {
            _WriteSegSizeByte(ms, 3);
            _WriteIDSeg(ms, id);
            _WriteByteValue(ms, mapvalue);
        }
        public static void _PresentationTextData(MemoryStream ms, string id)
        {
            _WriteSegStarter(ms);
            _WriteSegSize(ms, 2261);
            _WriteIDSeg(ms, id);
            _WriteStaticValue(ms, "000000");
            _WriteStaticValue(ms, "2BD3");

            _AMB(ms, 0xD2, 2886);
            _AMI(ms, 0xC6, 355);
            _SCFL(ms, 0xF0, 1);
            _TransparentData(ms, 0xDA, "CUSTOMER001", "windows-1252");
            //_TransparentData(ms, 0xDA, "CUSTOMER001", "IBM500");


            _AMB(ms, 0xD2, 3162);
            _AMI(ms, 0xC6, 355);
            _TransparentData(ms, 0xDA, "NO X SPG XXX", "windows-1252");
            _ReadExternalResource(ms, "QZ000001");

            _NOPCS(ms, 0xF8);


        }
        public static void _NOPCS(MemoryStream ms, byte id)
        {
            _WriteSegSizeByte(ms, 2);
            _WriteByteValue(ms, id);
        }
        public static void _AMB(MemoryStream ms, byte id, short value)
        {
            _WriteSegSizeByte(ms, 4);
            _WriteByteValue(ms, (byte)(id + 1));
            _WriteShortValue(ms, value);
        }
        public static void _AMI(MemoryStream ms, byte id, short value)
        {
            _WriteSegSizeByte(ms, 4);
            _WriteByteValue(ms, (byte)(id + 1));
            _WriteShortValue(ms, value);
        }
        public static void _SCFL(MemoryStream ms, byte id, byte lid)
        {
            _WriteSegSizeByte(ms, 3);
            _WriteByteValue(ms, (byte)(id + 1));
            _WriteByteValue(ms, lid);
        }
        public static void _STC(MemoryStream ms, byte id, ushort value)
        {
            _WriteSegSizeByte(ms, 4);
            _WriteByteValue(ms, (byte)(id + 1));
            _WriteShortValue(ms, value);
        }
        public static void _TransparentData(MemoryStream ms, byte id, string text, string encoding)
        {
            byte[] _strByteArray = _GetByteArrayFromString(text, encoding);
            _WriteSegSizeByte(ms, (byte)(_strByteArray.Length + 2));
            _WriteByteValue(ms, (byte)(id + 1));
            ms.Write(_strByteArray, 0, _strByteArray.Length);
        }
        public static void _BeginPresentationText(MemoryStream ms, string id)
        {
            _WriteSegStarter(ms);
            _WriteSegSize(ms, 8);
            _WriteIDSeg(ms, id);
            _WriteStaticValue(ms, "000006");

        }
        public static void _EndPresentationText(MemoryStream ms, string id)
        {
            _WriteSegStarter(ms);
            _WriteSegSize(ms, 8);
            _WriteIDSeg(ms, id);
            _WriteStaticValue(ms, "000001");

        }
        public static void _PageDescriptor(MemoryStream ms, string id, byte xpgbase, byte ypgbase,
            short xpgunits, short ypgunits, short xpgsize, short ypgsize, byte reserved)
        {
            _WriteSegStarter(ms);
            _WriteSegSize(ms, 23);
            _WriteIDSeg(ms, id);
            _WriteStaticValue(ms, "000001");
            _WriteByteValue(ms, xpgbase);
            _WriteByteValue(ms, ypgbase);
            _WriteShortValue(ms, xpgunits);
            _WriteShortValue(ms, ypgunits);
            _WriteStaticValue(ms, "00");
            _WriteShortValue(ms, xpgsize);
            _WriteStaticValue(ms, "00");
            _WriteShortValue(ms, ypgsize);
            _WriteStaticValue(ms, "000000");

        }
        public static void _MCF(MemoryStream ms, short size, string id)
        {
            _WriteSegStarter(ms);
            _WriteSegSize(ms, (ushort)size);
            _WriteIDSeg(ms, id);
            _WriteStaticValue(ms, "000000");
            _MCFRG(ms, 5, 1, 142, 0, "XZ000001", 0, 0, 240, 0, "000000000000", "000000000000");
            _MCFRG(ms, 5, 2, 142, 0, "XZ000001", 0, 0, 200, 0, "000000000000", "000000000000");
            _MCFRG(ms, 5, 3, 142, 0, "XZ000001", 0, 0, 180, 0, "000000000000", "000000000000");
            _MCFRG(ms, 5, 4, 142, 0, "XZ000002", 0, 0, 220, 0, "000000000000", "000000000000");
            _MCFRG(ms, 5, 5, 142, 0, "XZ000001", 0, 0, 220, 0, "000000000000", "000000000000");
            _MCFRG(ms, 5, 6, 142, 0, "XZ000002", 0, 0, 180, 0, "000000000000", "000000000000");
            _MCFRG(ms, 5, 7, 142, 0, "XZ000001", 0, 0, 180, 0, "000000000000", "000000000000");
            _MCFRG(ms, 5, 8, 142, 0, "XZ000002", 0, 0, 180, 0, "000000000000", "000000000000");

        }
        public static void _MCFRG(MemoryStream ms, byte restype, byte reslid, byte fqntype,
            byte fqnformat, string fqnname, byte ftwtclass, byte ftwdclass, short ftheight, short ftwidth,
            string ftdsflags, string ftusflags)
        {
            _WriteSegSize(ms, 38);
            _ResourceLocalIdentifier(ms, "24", restype, reslid);
            _FullyQualifiedName(ms, "02", fqntype, fqnformat, fqnname);
            _FontDescriptor(ms, "1F", ftwtclass, ftwdclass, ftheight, ftwidth, ftdsflags, ftusflags);
        }
        public static void _ResourceLocalIdentifier(MemoryStream ms, string id, byte restype, byte reslid)
        {
            _WriteSegSizeByte(ms, 4);
            _WriteIDSeg(ms, id);
            _WriteByteValue(ms, restype);
            _WriteByteValue(ms, reslid);
        }
        public static void _FullyQualifiedName(MemoryStream ms, string id, byte fqntype, byte fqnformat, string fqnname)
        {
            _WriteSegSizeByte(ms, 12);
            _WriteIDSeg(ms, id);
            _WriteByteValue(ms, fqntype);
            _WriteByteValue(ms, fqnformat);
            _WriteString(ms, fqnname, "IBM500");
        }
        public static void _FontDescriptor(MemoryStream ms, string id, byte ftwtclass, byte ftwdclass, short ftheight, short ftwidth, string ftdsflags, string ftusflags)
        {
            _WriteSegSizeByte(ms, 20);
            _WriteIDSeg(ms, id);
            _WriteByteValue(ms, ftwtclass);
            _WriteByteValue(ms, ftwdclass);
            _WriteShortValue(ms, ftheight);
            _WriteShortValue(ms, ftwidth);
            _WriteStaticValue(ms, ftdsflags);
            _WriteStaticValue(ms, ftusflags);
        }
        public static void _BeginActiveEnvirommentGroup(MemoryStream ms, string id)
        {
            _WriteSegStarter(ms);
            _WriteSegSize(ms, 8);
            _WriteIDSeg(ms, id);
            _WriteStaticValue(ms, "000000");
        }
        public static void _EndActiveEnvirommentGroup(MemoryStream ms, string id)
        {
            _WriteSegStarter(ms);
            _WriteSegSize(ms, 8);
            _WriteIDSeg(ms, id);
            _WriteStaticValue(ms, "000002");
        }
        public static void _BeginPage(MemoryStream ms, string id)
        {
            _WriteSegStarter(ms);
            _WriteSegSize(ms, 8);
            _WriteIDSeg(ms, id);
            _WriteStaticValue(ms, "000001");
        }
        public static void _EndPage(MemoryStream ms, string id)
        {
            _WriteSegStarter(ms);
            _WriteSegSize(ms, 8);
            _WriteIDSeg(ms, id);
            _WriteStaticValue(ms, "000007");
        }
        public static void _EndDocument(MemoryStream ms, string id, string encoding)
        {
            _WriteSegStarter(ms);
            _WriteSegSize(ms, 8);
            _WriteIDSeg(ms, id);
            _WriteStaticValue(ms, "00001F");
        }
        public static void _BeginDocument(MemoryStream ms, string id, string docName, string reserved, string encoing)
        {
            _WriteSegStarter(ms);
            _WriteSegSize(ms, 24);
            _WriteIDSeg(ms, id);
            _WriteStaticValue(ms, "000000");
            _WriteString(ms, docName, "IBM500");
            _WriteStaticValue(ms, "200000");
            _CGCSGID(ms, "01", "FFFF", "04B8");
        }
        public static void _CGCSGID(MemoryStream ms, string id, string CGCID, string CPGID)
        {
            _WriteSegSizeByte(ms, 6);
            _WriteIDSeg(ms, id);
            _WriteStaticValue(ms, CGCID);
            _WriteStaticValue(ms, CPGID);
        }
        public static void _BeginResourceGroup(MemoryStream ms, string id)
        {
            _WriteSegStarter(ms);
            _WriteSegSize(ms, 8);
            _WriteIDSeg(ms, id);
            _WriteStaticValue(ms, "000000");
        }
        public static void _EndResourceGroup(MemoryStream ms, string id)
        {
            _WriteSegStarter(ms);
            _WriteSegSize(ms, 8);
            _WriteIDSeg(ms, id);
            _WriteStaticValue(ms, "00000C");
        }
        public static void _BeginResource(MemoryStream ms, string id, string rsname)
        {
            _WriteSegStarter(ms);
            _WriteSegSize(ms, 28);
            _WriteIDSeg(ms, id);
            _WriteStaticValue(ms, "000000");
            _WriteRSName(ms, rsname);
            _WriteStaticValue(ms, "0000");
            _ResourceObjectType(ms, "21", 65, "00000000000000");
        }
        public static void _BeginResourceImage(MemoryStream ms, string id, string rsname)
        {
            _WriteSegStarter(ms);
            _WriteSegSize(ms, 52);
            _WriteIDSeg(ms, id);
            _WriteStaticValue(ms, "000000");
            _WriteRSName(ms, rsname);
            _WriteStaticValue(ms, "0000");
            _ResourceObjectType(ms, "21", 146, "00000000000000");
        }
        public static void _BeginObjectContatiner(MemoryStream ms, string id, string rsname)
        {
            _WriteSegStarter(ms);
            _WriteSegSize(ms, 40);
            _WriteIDSeg(ms, id);
            _WriteStaticValue(ms, "000000");
            _WriteRSName(ms, rsname);
            _ObjectClassification(ms, "10", "06072B12000401011700000000000000");
        }
        public static void _ObjectClassification(MemoryStream ms, string id, string regObjId)
        {
            _WriteSegSizeByte(ms, 24);
            _WriteIDSeg(ms, id);
            _WriteStaticValue(ms, "00010000FC00");
            _WriteStaticValue(ms, regObjId);
        }
        public static void _ObjectContainerData(MemoryStream ms, string id, string rsname)
        {
            _WriteSegStarter(ms);
            _WriteSegSize(ms, (ushort)(_GetLength(ms, rsname) + 8));
            _WriteIDSeg(ms, id);
            _WriteStaticValue(ms, "000000");
            _ReadExternalResource(ms, rsname);
        }
        public static void _BeginFontResource(MemoryStream ms, string id, string rsname, byte codepage)
        {
            _WriteSegStarter(ms);
            _WriteSegSize(ms, 28);
            _WriteIDSeg(ms, id);
            _WriteStaticValue(ms, "000000");
            _WriteRSName(ms, rsname);
            _WriteStaticValue(ms, "0000");
            _ResourceObjectType(ms, "21", codepage, "00000000000000");
        }
        public static void _ReadExternalResource(MemoryStream ms, string rsname)
        {
            byte[] inputBytes;
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = $"pdfafp.ext.{rsname}";
            using (var stream = assembly.GetManifestResourceStream(resourceName))
            /*using (FileStream inputFs = new FileStream(rsname, FileMode.Open, FileAccess.Read))*/
            {
                inputBytes = new byte[stream.Length];
                stream.Read(inputBytes, 0, inputBytes.Length);
            }
            ms.Write(inputBytes, 0, inputBytes.Length);
        }
        public static ushort _GetLength(MemoryStream ms, string rsname)
        {
            byte[] inputBytes;
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = $"pdfafp.ext.{rsname}";
            using (var stream = assembly.GetManifestResourceStream(resourceName))
            /*using (FileStream inputFs = new FileStream(rsname, FileMode.Open, FileAccess.Read))*/
            {
                inputBytes = new byte[stream.Length];
                stream.Read(inputBytes, 0, inputBytes.Length);
            }
            return (ushort)inputBytes.Length;
        }
        public static void _ResourceObjectType(MemoryStream ms, string id, byte codepage, string conddata)
        {

            _WriteSegSizeByte(ms, 10);
            _WriteIDSeg(ms, id);
            ms.WriteByte(codepage);
            _WriteStringValue(ms, conddata);
        }
        public static void _EndObjectContainer(MemoryStream ms, string id)
        {
            _WriteSegStarter(ms);
            _WriteSegSize(ms, 8);
            _WriteIDSeg(ms, id);
            _WriteStaticValue(ms, "000001");
        }

        public static void _EndImageResource(MemoryStream ms, string id, string rsname)
        {
            _WriteSegStarter(ms);
            _WriteSegSize(ms, 18);
            _WriteIDSeg(ms, id);
            _WriteStaticValue(ms, "000001");
            _WriteRSName(ms, rsname);
            _WriteStaticValue(ms, "0000");
        }
        public static void _EndResource(MemoryStream ms, string id)
        {
            _WriteSegStarter(ms);
            _WriteSegSize(ms, 8);
            _WriteIDSeg(ms, id);
            _WriteStaticValue(ms, "000001");
        }
        public static void _WriteRSName(MemoryStream ms, string rsname)
        {
            byte[] byteArray = _GetByteArrayFromString(rsname, "IBM500");
            ms.Write(byteArray, 0, byteArray.Length);
        }
        public static void _WriteString(MemoryStream ms, string str, string encoding)
        {
            byte[] byteArray = _GetByteArrayFromString(str, encoding);
            ms.Write(byteArray, 0, byteArray.Length);
        }
        public static byte[] _GetByteArrayFromString(string str, string encoding)
        {
            byte[] bytes = Encoding.GetEncoding(encoding).GetBytes(str);
            return bytes;
        }
        public static byte[] _GetByteArrayFromString(string str, int encoding)
        {
            byte[] bytes = Encoding.GetEncoding(encoding).GetBytes(str);
            return bytes;
        }
        public static void _WriteIDSeg(MemoryStream ms, string id)
        {
            _WriteStringValue(ms, id);
        }
        public static void _WriteStaticValue(MemoryStream ms, string value)
        {
            _WriteStringValue(ms, value);
        }
        public static void _WriteStringValue(MemoryStream ms, string value)
        {
            byte[] byteArray = System.Convert.FromHexString(value);
            ms.Write(byteArray, 0, byteArray.Length);
        }
        public static void _WriteSegSize(MemoryStream ms, ushort size)
        {
            _WriteShortValue(ms, size);
        }

        public static void _WriteShortValue(MemoryStream ms, short value)
        {
            byte[] byteArray = BitConverter.GetBytes(value);
            Array.Reverse(byteArray);
            ms.Write(byteArray, 0, byteArray.Length);
        }
        public static void _WriteShortValue(MemoryStream ms, ushort value)
        {
            byte[] byteArray = BitConverter.GetBytes(value);
            Array.Reverse(byteArray);
            ms.Write(byteArray, 0, byteArray.Length);
        }
        public static void _WriteSegSizeByte(MemoryStream ms, byte size)
        {
            _WriteByteValue(ms, size);
        }
        public static void _WriteByteValue(MemoryStream ms, byte size)
        {
            ms.WriteByte(size);
        }
        public static void _WriteSegStarter(MemoryStream ms)
        {
            byte[] bytes = new byte[] { 0x5a };
            ms.Write(bytes, 0, bytes.Length);
        }
        public static void _WriteAFPHeader(MemoryStream ms)
        {
            // AFP header (BPGBDH)
            string hexString = "5A00CCD3A8A8000000C4D6C3E4D4C5D5E300000601FFFF01F40518010C002765E2819497938540C1C6D74086899385404040404040404040404040404040404040404040402D65E2819497938540C1C6D74086899385404040404040404040404040404040404040404040404040404040402265F2F0F1F0F0F660C3E4D9D9C5D5E340404040404040404040404040404040404022659596A340848586899585844040404040404040404040404040404040404040401765E389948540F2F0F1F0F1F2F3F1F1F9F3F7F5F9F9F3";
            byte[] bytes = new byte[hexString.Length / 2];

            for (int i = 0; i < bytes.Length; i++)
            {
                bytes[i] = byte.Parse(hexString.Substring(i * 2, 2), System.Globalization.NumberStyles.HexNumber);
            }
            ms.Write(bytes, 0, bytes.Length);
        }

        public static void ExtractTextFromPDF(string pdfPath)
        {
            /*using (PdfDocument document = PdfReader.Open(pdfPath, PdfDocumentOpenMode.Import))
            {
                for (int pageIndex = 0; pageIndex < document.Pages.Count; pageIndex++)
                {
                    PdfPage page = document.Pages[pageIndex];
                    Console.WriteLine($"Page {pageIndex + 1}:");

                    foreach (XGraphicsObject obj in page.Elements)
                    {
                        if (obj is XText)
                        {
                            XText text = (XText)obj;
                            Console.WriteLine($"- Text: '{text.Text}', Font={text.Font.FontName}, Size={text.Size}, Position=({text.X}, {text.Y})");
                        }
                    }
                }
            }*/
        }
        public static void ParsePDFElements(string pdfFilePath)
        {
            PdfDocument document = PdfReader.Open(pdfFilePath);

            int imageCount = 0;
            // Iterate pages
            foreach (PdfPage page in document.Pages)
            {
                // Get resources dictionary
                PdfDictionary resources = page.Elements.GetDictionary("/Resources");
                if (resources != null)
                {
                    // Get external objects dictionary
                    PdfDictionary xObjects = resources.Elements.GetDictionary("/XObject");
                    if (xObjects != null)
                    {
                        ICollection<PdfItem> items = xObjects.Elements.Values;
                        // Iterate references to external objects
                        foreach (PdfItem item in items)
                        {
                            PdfReference reference = item as PdfReference;
                            if (reference != null)
                            {
                                PdfDictionary xObject = reference.Value as PdfDictionary;
                                // Is external object an image?
                                //Debug.Write(xObject.Elements.GetString("/Subtype"));
                                Debug.WriteLine(xObject.Elements.GetString("/Subtype"));
                                if (xObject != null && xObject.Elements.GetString("/Subtype") == "/Image")
                                {
                                    ExportImage(xObject, ref imageCount);
                                }
                            }
                        }
                    }
                }
                break;
            }
        }
        static void ExportImage(PdfDictionary image, ref int count)
        {
            string filter = image.Elements.GetName("/Filter");
            Debug.Write(filter);
            switch (filter)
            {
                case "/DCTDecode":
                    ExportJpegImage(image, ref count);
                    break;

                case "/FlateDecode":
                    ExportAsPngImage(image, ref count);
                    break;
            }
        }
        static void ExportAsPngImage(PdfDictionary image, ref int count)
        {
            int width = image.Elements.GetInteger(PdfSharp.Pdf.Advanced.PdfImage.Keys.Width);
            int height = image.Elements.GetInteger(PdfSharp.Pdf.Advanced.PdfImage.Keys.Height);
            int bitsPerComponent = image.Elements.GetInteger(PdfSharp.Pdf.Advanced.PdfImage.Keys.BitsPerComponent);
            var ColorSpace = image.Elements.GetArray(PdfImage.Keys.ColorSpace);
            System.Drawing.Imaging.PixelFormat pixelFormat = System.Drawing.Imaging.PixelFormat.Format24bppRgb; //24 just for initalize

            if (ColorSpace is null) //no colorspace.. bufferedimage?? is in BGR order instead of RGB so change the byte order. Right now it works
            {
                byte[] origineel_byte_boundary = image.Stream.UnfilteredValue;
                bitsPerComponent = (origineel_byte_boundary.Length) / (width * height);
                switch (bitsPerComponent)
                {
                    case 4:
                        pixelFormat = System.Drawing.Imaging.PixelFormat.Format32bppPArgb;
                        break;
                    case 3:
                        pixelFormat = System.Drawing.Imaging.PixelFormat.Format24bppRgb;
                        break;
                    default:
                        {
                            MessageBox.Show("Unknown pixel format " + bitsPerComponent, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            
                        }
                        break;
                }
                Bitmap bmp = new Bitmap(width, height, pixelFormat); //copy raw bytes to "master" bitmap so we are out of pdf format to work with 
                System.Drawing.Imaging.BitmapData bmd = bmp.LockBits(new Rectangle(0, 0, width, height), System.Drawing.Imaging.ImageLockMode.WriteOnly, pixelFormat);
                System.Runtime.InteropServices.Marshal.Copy(origineel_byte_boundary, 0, bmd.Scan0, origineel_byte_boundary.Length);
                bmp.UnlockBits(bmd);
                Bitmap bmp2 = new Bitmap(width, height, pixelFormat);
                for (int indicex = 0; indicex < bmp.Width; indicex++)
                {
                    for (int indicey = 0; indicey < bmp.Height; indicey++)
                    {
                        Color nuevocolor = bmp.GetPixel(indicex, indicey);
                        Color colorintercambiado = Color.FromArgb(nuevocolor.A, nuevocolor.B, nuevocolor.G, nuevocolor.R);
                        bmp2.SetPixel(indicex, indicey, colorintercambiado);
                    }
                }
                using (FileStream fs = new FileStream(String.Format("Image{0}.png", count++), FileMode.Create, FileAccess.Write))
                {
                    bmp2.Save(fs, System.Drawing.Imaging.ImageFormat.Png);
                }
                bmp2.Dispose();
                bmp.Dispose();
            }
            else
            {
                // this is the case of photoshop... work needs to be done here. I ´m able to get the color palette but no idea how to put it back or create the png file... 
                switch (bitsPerComponent)
                {
                    case 4:
                        pixelFormat = System.Drawing.Imaging.PixelFormat.Format32bppArgb;
                        break;
                    default:
                        {
                            MessageBox.Show("Unknown pixel format " + bitsPerComponent, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            
                        }
                        break;
                }
                if ((ColorSpace.Elements.GetName(0) == "/Indexed") && (ColorSpace.Elements.GetName(1) == "/DeviceRGB"))
                {
                    //we need to create the palette
                    int paletteColorCount = ColorSpace.Elements.GetInteger(2);
                    List<System.Drawing.Color> paletteList = new List<Color>();
                    //Color[] palette = new Color[paletteColorCount+1]; // no idea why but it seams that there´s always 1 color more. ¿transparency?
                    PdfObject paletteObj = ColorSpace.Elements.GetObject(3);
                    PdfDictionary paletteReference = (PdfDictionary)paletteObj;
                    byte[] palettevalues = paletteReference.Stream.Value;
                    for (int index = 0; index < (paletteColorCount + 1); index++)
                    {
                        //palette[index] = Color.FromArgb(1, palettevalues[(index*3)], palettevalues[(index*3)+1], palettevalues[(index*3)+2]); // RGB
                        paletteList.Add(Color.FromArgb(1, palettevalues[(index * 3)], palettevalues[(index * 3) + 1], palettevalues[(index * 3) + 2])); // RGB
                    }
                }
            }
        }
        static void ExportJpegImage(PdfDictionary image, ref int count)
        {
            // Fortunately JPEG has native support in PDF and exporting an image is just writing the stream to a file.
            byte[] stream = image.Stream.Value;
            FileStream fs = new FileStream(String.Format("Image{0}.jpeg", count++), FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(stream);
            bw.Close();
        }
        public static void CreateAFPFileWithImage(string file_path)
        {
            Image image = Image.FromFile(file_path);

            // Set the desired image size (100x100)
            int imageWidth = 100;
            int imageHeight = 100;

            // Set the desired image position on the page (0,0)
            float imageX = 0.0f;
            float imageY = 0.0f;

            // Create the AFP data stream
            byte[] afpData = CreateAFPDataStream(image, imageWidth, imageHeight, imageX, imageY);

            // Save the AFP data stream to a file
            File.WriteAllBytes("output.afp", afpData);

            Console.WriteLine("AFP file created successfully.");
        }
        public static byte[] CreateAFPDataStream(Image image, int imageWidth, int imageHeight, float imageX, float imageY)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                // Write the AFP data stream header
                WriteAFPHeader(ms);

                // Write the page definition
                /*WritePageDefinition(ms, imageWidth, imageHeight, imageX, imageY);*/

                // Write the image data
                //WriteImageData(ms, image);
                //WriteTextData(ms, "qweqwe");

                // Write the end of file marker
                //WriteEndOfFile(ms);

                return ms.ToArray();
            }
        }

        public static void WriteAFPHeader(MemoryStream ms)
        {
            // AFP header (BPGBDH)
            string hexString = "5A00CCD3A8A8000000C4D6C3E4D4C5D5E300000601FFFF01F40518010C002765E2819497938540C1C6D74086899385404040404040404040404040404040404040404040402D65E2819497938540C1C6D74086899385404040404040404040404040404040404040404040404040404040402265F2F0F1F0F0F660C3E4D9D9C5D5E340404040404040404040404040404040404022659596A340848586899585844040404040404040404040404040404040404040401765E389948540F2F0F1F0F1F2F3F1F1F9F3F7F5F9F9F3";
            byte[] bytes = new byte[hexString.Length / 2];

            for (int i = 0; i < bytes.Length; i++)
            {
                bytes[i] = byte.Parse(hexString.Substring(i * 2, 2), System.Globalization.NumberStyles.HexNumber);
            }
            ms.Write(bytes, 0, bytes.Length);

            hexString = "5A0010D3A8AF000000F140404040404040";
            byte[] bytes_page_start = new byte[hexString.Length / 2];

            for (int i = 0; i < bytes_page_start.Length; i++)
            {
                bytes_page_start[i] = byte.Parse(hexString.Substring(i * 2, 2), System.Globalization.NumberStyles.HexNumber);
            }
            ms.Write(bytes_page_start, 0, bytes_page_start.Length);

            hexString = "5A0010D3A9AF000000F140404040404040";
            byte[] bytes_page_end = new byte[hexString.Length / 2];

            for (int i = 0; i < bytes_page_end.Length; i++)
            {
                bytes_page_end[i] = byte.Parse(hexString.Substring(i * 2, 2), System.Globalization.NumberStyles.HexNumber);
            }
            ms.Write(bytes_page_end, 0, bytes_page_end.Length);

            hexString = "5A0010D3A9A8000002C4D6C3E4D4C5D5E3";
            byte[] bytes_end = new byte[hexString.Length / 2];

            for (int i = 0; i < bytes_end.Length; i++)
            {
                bytes_end[i] = byte.Parse(hexString.Substring(i * 2, 2), System.Globalization.NumberStyles.HexNumber);
            }
            ms.Write(bytes_end, 0, bytes_end.Length);
        }

        public static void WriteImageData(MemoryStream ms, Image image)
        {
            byte[] includeDocument = new byte[]
            {
                0x5C, 0xC9, 0xCE, 0xC3, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00
            };
            ms.Write(includeDocument, 0, includeDocument.Length);

            // Write image data
            using (MemoryStream imageMs = new MemoryStream())
            {
                // Save the image to the memory stream in the JPEG format
                image.Save(imageMs, ImageFormat.Jpeg);

                // Write the JPEG image data to the AFP data stream
                byte[] imageData = imageMs.ToArray();
                ms.Write(imageData, 0, imageData.Length);
            }
        }
        public static void WriteTextData(MemoryStream ms, string text)
        {
            // Write the text as EBCDIC-encoded bytes
            byte[] textBytes = Encoding.GetEncoding("UTF-8").GetBytes(text);

            // Text Data (PTX) Structured Field
            byte[] ptx = new byte[textBytes.Length + 10];
            ptx[0] = 0x5A;
            ptx[1] = 0xD5;
            ptx[2] = (byte)((textBytes.Length + 6) >> 8);
            ptx[3] = (byte)(textBytes.Length + 6);
            ptx[4] = 0x00;
            ptx[5] = 0x00;
            ptx[6] = 0x00;
            ptx[7] = 0x00;
            ptx[8] = 0x00;
            ptx[9] = 0x00;

            Array.Copy(textBytes, 0, ptx, 10, textBytes.Length);
            ms.Write(ptx, 0, ptx.Length);
        }
        public static void WriteEndOfFile(MemoryStream ms)
        {
            // END FILE (EOF)
            byte[] epg = new byte[]
            {
                0x5A, 0xD4, 0x08, 0x00, 0x00, 0x00, 0x00, 0x00
            };
            ms.Write(epg, 0, epg.Length);

            // End File (EOF) Structured Field
            byte[] eof = new byte[]
            {
                0x5A, 0xC1, 0x08, 0x00, 0x00, 0x00, 0x00, 0x00
            };
            ms.Write(eof, 0, eof.Length);
        }
        public static void ConvertImagesToAFP(IEnumerable<Image> images, string outputFilePath)
        {
            using (MemoryStream afpStream = new MemoryStream())
            {
                // Write the AFP Prefix
                WriteAFPPrefix(afpStream);

                // Write the AFP Image Data
                foreach (Image image in images)
                {
                    WriteAFPImageData(afpStream, image);
                }

                // Write the AFP Suffix
                WriteAFPSuffix(afpStream);

                // Save the AFP file
                File.WriteAllBytes(outputFilePath, afpStream.ToArray());
            }
        }

        private static void WriteAFPPrefix(Stream stream)
        {
            // Write the AFP Prefix data
            // This includes the AFPDS header, Structured Field Introducer, etc.
            // You'll need to research the AFP file format specification to implement this correctly
        }

        private static void WriteAFPImageData(Stream stream, Image image)
        {
            // Write the AFP Image Data
            // This includes the Image Block Structured Field, Image Data Descriptor, and the actual image data
            // You'll need to research the AFP file format specification to implement this correctly
        }

        private static void WriteAFPSuffix(Stream stream)
        {
            // Write the AFP Suffix data
            // This includes the End Document Structured Field, etc.
            // You'll need to research the AFP file format specification to implement this correctly
        }
    }

}
