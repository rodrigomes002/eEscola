﻿using eEscola.Application.Models;
using eEscola.Application.Results;
using eEscola.Domain.Entities;

namespace eEscola.Application
{
    public interface IAlunoApplication
    {
        Task<Result<IEnumerable<Aluno>>> GetAll();
        Task<Result<Aluno>> GetById(int id);
        Task<Result<bool>> Add(Aluno aluno);
        Task<Result<bool>> Edit(Aluno aluno);
        Task<Result<bool>> Delete(int id);
    }
}
