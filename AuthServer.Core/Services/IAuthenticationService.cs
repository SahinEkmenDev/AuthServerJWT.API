﻿using AuthServer.Core.DTOs;
using SharedLibrary.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthServer.Core.Services
{
    public interface IAuthenticationService
    {
        Task<Response<TokenDto>> CreateTokenAsync(LogginDto logginDto);
        Task<Response<TokenDto>> CreateTokenByRefreshToken( string refreshToken );

        Task<Response<NoDataDto>> RevokeRefreshToken (string refreshToken );
        Task<Response<ClientTokenDto>> CreateTokenByClient(ClientLogginDto clientLogginDto);

    }
}
