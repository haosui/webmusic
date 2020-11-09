import type { AuditedEntityDto } from '@abp/ng.core';

export interface AlbumDto extends AuditedEntityDto<string> {
  name: string;
  description: string;
  imagepath: string;
}

export interface CreateUpdateAlbumDto {
  name: string;
  description: string;
  imagepath: string;
}
