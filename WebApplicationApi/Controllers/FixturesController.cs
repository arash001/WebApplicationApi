using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Xml.Serialization;
using WebApplicationApi.BO;
using WebApplicationApi.DataAccess;
using WebApplicationApi.Model;
using WebApplicationApi.ViewModel;

namespace WebApplicationApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FixturesController : ControllerBase
    {
        private readonly ILogger<FixturesController> _logger;
        private readonly IMapper _mapper;
        AppDbContext _appDbContext;
        private readonly IConfiguration _configuration;

        public FixturesController(ILogger<FixturesController> logger, IMapper mapper, AppDbContext appDbContext, IConfiguration configuration)
        {
            _logger = logger;
            _mapper = mapper;
            _appDbContext=appDbContext;
            _configuration = configuration;
        }

        [HttpGet("GetPutDataRequest", Name = "GetPutDataRequest")]
        public async Task<PutDataRequestDto> GetPutDataRequest()
        {
            try
            {
                XmlReaderUtil xmlReaderUtil = new XmlReaderUtil();
                PutDataRequestDto putDataRequestDto = new PutDataRequestDto();

                putDataRequestDto = await xmlReaderUtil.getXmlFromFile(_configuration["XmlFilePath"]);
                var putDataRequestDb = _mapper.Map<PutDataRequest>(putDataRequestDto);
                PutDataRequestDA putDataRequestDAObj = new PutDataRequestDA(_appDbContext);
                putDataRequestDAObj.AddPutDataRequest(putDataRequestDb);
                return putDataRequestDto;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [HttpPost(Name = "AddPutDataRequest")]

            public void Post([FromBody] PutDataRequestDto putDataRequestDto)
            {
                var putDataRequest=_mapper.Map< PutDataRequest>(putDataRequestDto);
                PutDataRequestDA putDataRequestDAObj = new PutDataRequestDA(_appDbContext);
                putDataRequestDAObj.AddPutDataRequest(putDataRequest);

            }

        //For Api to get Xml
        [HttpGet("GetPutDataRequestFromApi", Name = "GetPutDataRequestFromApi")]
        public async Task<PutDataRequestDto> GetPutDataRequestFromApi()
        {
            using (HttpClient httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync(_configuration["api"]);
                response.EnsureSuccessStatusCode();
                var xmlContent = await response.Content.ReadAsStringAsync();

                var serializer = new XmlSerializer(typeof(PutDataRequestDto));
                using (var reader = new StringReader(xmlContent))
                {
                    var putDataRequestDto = (PutDataRequestDto)serializer.Deserialize(reader);
                    return putDataRequestDto;
                }
            }
        }
    }
}
