//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 0.3.5463.23402.
namespace IS24RestApi.Offer.Productrecommondation
{
    using System.Collections.ObjectModel;
    using System.Xml.Serialization;
    
    
    /// <summary>
    /// <para>List of all possible products and the recommended one</para>
    /// </summary>
    [System.SerializableAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "0.3.5463.23402")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute("productRecommendation", Namespace="http://rest.immobilienscout24.de/schema/offer/productrecommondation/1.0")]
    [System.Xml.Serialization.XmlRootAttribute("productRecommendation", Namespace="http://rest.immobilienscout24.de/schema/offer/productrecommondation/1.0")]
    public partial class ProductRecommendation
    {
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("product", Namespace="http://rest.immobilienscout24.de/schema/offer/productrecommondation/1.0")]
        public Collection<Product> Product { get; private set; }
        
        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="ProductRecommendation" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="ProductRecommendation" /> class.</para>
        /// </summary>
        public ProductRecommendation()
        {
            this.Product = new Collection<Product>();
        }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("recommendedProduct", Namespace="http://rest.immobilienscout24.de/schema/offer/productrecommondation/1.0", IsNullable=true)]
        public Product RecommendedProduct { get; set; }
    }
    
    /// <summary>
    /// </summary>
    [System.SerializableAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "0.3.5463.23402")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute("product", Namespace="http://rest.immobilienscout24.de/schema/offer/productrecommondation/1.0")]
    public partial class Product
    {
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("articleNumber", Namespace="http://rest.immobilienscout24.de/schema/offer/productrecommondation/1.0", DataType="string")]
        public string ArticleNumber { get; set; }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("price", Namespace="http://rest.immobilienscout24.de/schema/offer/productrecommondation/1.0", DataType="decimal")]
        public decimal Price { get; set; }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("priceRegion", Namespace="http://rest.immobilienscout24.de/schema/offer/productrecommondation/1.0")]
        public PriceRegion PriceRegion { get; set; }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("maxRealEstates", Namespace="http://rest.immobilienscout24.de/schema/offer/productrecommondation/1.0")]
        public int MaxRealEstates { get; set; }
    }
    
    /// <summary>
    /// </summary>
    [System.SerializableAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "0.3.5463.23402")]
    [System.Xml.Serialization.XmlTypeAttribute("priceRegion", Namespace="http://rest.immobilienscout24.de/schema/offer/productrecommondation/1.0")]
    public enum PriceRegion
    {
        
        /// <summary>
        /// </summary>
        A,
        
        /// <summary>
        /// </summary>
        B,
        
        /// <summary>
        /// </summary>
        C,
        
        /// <summary>
        /// </summary>
        D,
        
        /// <summary>
        /// </summary>
        E,
    }
}
