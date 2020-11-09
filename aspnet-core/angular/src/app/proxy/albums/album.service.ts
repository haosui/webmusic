import type { AlbumDto, CreateUpdateAlbumDto } from './models';
import { RestService } from '@abp/ng.core';
import type { PagedAndSortedResultRequestDto, PagedResultDto } from '@abp/ng.core';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class AlbumService {
  apiName = 'Default';

  create = (input: CreateUpdateAlbumDto) =>
    this.restService.request<any, AlbumDto>({
      method: 'POST',
      url: `/api/app/album`,
      body: input,
    },
    { apiName: this.apiName });

  delete = (id: string) =>
    this.restService.request<any, void>({
      method: 'DELETE',
      url: `/api/app/album/${id}`,
    },
    { apiName: this.apiName });

  get = (id: string) =>
    this.restService.request<any, AlbumDto>({
      method: 'GET',
      url: `/api/app/album/${id}`,
    },
    { apiName: this.apiName });

  getList = (input: PagedAndSortedResultRequestDto) =>
    this.restService.request<any, PagedResultDto<AlbumDto>>({
      method: 'GET',
      url: `/api/app/album`,
      params: { sorting: input.sorting, skipCount: input.skipCount, maxResultCount: input.maxResultCount },
    },
    { apiName: this.apiName });

  update = (id: string, input: CreateUpdateAlbumDto) =>
    this.restService.request<any, AlbumDto>({
      method: 'PUT',
      url: `/api/app/album/${id}`,
      body: input,
    },
    { apiName: this.apiName });

  constructor(private restService: RestService) {}
}
