import type { CreateUpdateSongDto, SongDto } from './models';
import { RestService } from '@abp/ng.core';
import type { PagedAndSortedResultRequestDto, PagedResultDto } from '@abp/ng.core';
import { Injectable } from '@angular/core';
import type { ReportDto } from '../reports/models';

@Injectable({
  providedIn: 'root',
})
export class SongService {
  apiName = 'Default';

  create = (input: CreateUpdateSongDto) =>
    this.restService.request<any, SongDto>({
      method: 'POST',
      url: `/api/app/song`,
      body: input,
    },
    { apiName: this.apiName });

  delete = (id: string) =>
    this.restService.request<any, void>({
      method: 'DELETE',
      url: `/api/app/song/${id}`,
    },
    { apiName: this.apiName });

  gelistreportByIdsong = (idsong: string) =>
    this.restService.request<any, ReportDto[]>({
      method: 'POST',
      url: `/api/app/song/gelistreport`,
      params: { idsong: idsong },
    },
    { apiName: this.apiName });

  get = (id: string) =>
    this.restService.request<any, SongDto>({
      method: 'GET',
      url: `/api/app/song/${id}`,
    },
    { apiName: this.apiName });

  getList = (input: PagedAndSortedResultRequestDto) =>
    this.restService.request<any, PagedResultDto<SongDto>>({
      method: 'GET',
      url: `/api/app/song`,
      params: { sorting: input.sorting, skipCount: input.skipCount, maxResultCount: input.maxResultCount },
    },
    { apiName: this.apiName });

  listSongByLimitfrom = (limitfrom: number) =>
    this.restService.request<any, SongDto[]>({
      method: 'POST',
      url: `/api/app/song/listSong`,
      params: { limitfrom: limitfrom },
    },
    { apiName: this.apiName });

  sOngSearchbynameByKeyAndLimitfrom = (key: string, limitfrom: number) =>
    this.restService.request<any, SongDto[]>({
      method: 'POST',
      url: `/api/app/song/sOngSearchbyname`,
      params: { key: key, limitfrom: limitfrom },
    },
    { apiName: this.apiName });

  searchbyTagByTaggAndLimitfrom = (tagg: string, limitfrom: number) =>
    this.restService.request<any, SongDto[]>({
      method: 'POST',
      url: `/api/app/song/searchbyTag`,
      params: { tagg: tagg, limitfrom: limitfrom },
    },
    { apiName: this.apiName });

  songListByPlaylistByLimitfromAndIdplaylist = (limitfrom: number, idplaylist: string) =>
    this.restService.request<any, SongDto[]>({
      method: 'POST',
      url: `/api/app/song/songListByPlaylist`,
      params: { limitfrom: limitfrom, idplaylist: idplaylist },
    },
    { apiName: this.apiName });

  songListBySingerByTextAndLimitfrom = (text: string, limitfrom: number) =>
    this.restService.request<any, SongDto[]>({
      method: 'POST',
      url: `/api/app/song/songListBySinger`,
      params: { text: text, limitfrom: limitfrom },
    },
    { apiName: this.apiName });

  songlistByAuthorByAuthotAndLimitfrom = (authot: string, limitfrom: number) =>
    this.restService.request<any, SongDto[]>({
      method: 'POST',
      url: `/api/app/song/songlistByAuthor`,
      params: { authot: authot, limitfrom: limitfrom },
    },
    { apiName: this.apiName });

  update = (id: string, input: CreateUpdateSongDto) =>
    this.restService.request<any, SongDto>({
      method: 'PUT',
      url: `/api/app/song/${id}`,
      body: input,
    },
    { apiName: this.apiName });

  chartByLimitfrom = (limitfrom: number) =>
    this.restService.request<any, SongDto[]>({
      method: 'POST',
      url: `/api/app/song/chart`,
      params: { limitfrom: limitfrom },
    },
    { apiName: this.apiName });

  constructor(private restService: RestService) {}
}
