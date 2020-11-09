import type { AuditedEntityDto } from '@abp/ng.core';

export interface AuthorDto extends AuditedEntityDto<string> {
  name: string;
  description: string;
  imagepath: string;
}

export interface CreateUpdateAuthorDto {
  name: string;
  description: string;
  imagepath: string;
}

export interface CreateUpdateSingerDto {
  name: string;
  gender: string;
  birthday: string;
  bio: string;
  imagepath: string;
}

export interface CreateUpdateSongbySingerDto {
  songId: string;
  singerId: string;
  songpath: string;
  imgpaht: string;
}

export interface SingerDto extends AuditedEntityDto<string> {
  name: string;
  gender: string;
  birthday: string;
  bio: string;
  imagepath: string;
}

export interface SongbySingerDto extends AuditedEntityDto<string> {
  songId: string;
  singerId: string;
  songpath: string;
  imgpaht: string;
}
