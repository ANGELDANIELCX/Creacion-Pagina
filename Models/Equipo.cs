using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
namespace Tuproyecto.Models
{
    public class Equipo
    {
        [BsoInd]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set;}

        [BsonElement("escuela")]
        public string Escuela {get; set;}

                [BsonElement("carrera")]
        public string Carrera { get; set; }

        [BsonElement("grupo")]
        public string Grupo { get; set; }

        [BsonElement("datos_semestre")]
        public int DatosSemestre { get; set; }

        [BsonElement("proyecto")]
        public string Proyecto { get; set; }

        [BsonElement("integrante1")]
        public string Integrante1 { get; set; }

        [BsonElement("integrante2")]
        public string Integrante2 { get; set; }

        [BsonElement("fecha")]
        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        public DateTime Fecha { get; set; }
    }
}

    