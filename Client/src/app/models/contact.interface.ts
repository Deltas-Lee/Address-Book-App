export interface Contact {
  id: number;
  fullName: string;
  email: string;
  phoneNumber?: string;
  address?: string;
  city?: string;
  province?: string;
  zipCode?: string;
  createdAt: string;
  updatedAt: string;
}

export interface ContactResponse {
  contacts: Contact[];
  totalCount: number;
}
