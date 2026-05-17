-- Table: public.rols

-- DROP TABLE IF EXISTS public.rols;

CREATE TABLE IF NOT EXISTS public.rols
(
    id integer NOT NULL DEFAULT nextval('rols_id_seq'::regclass),
    rol_name character varying(20) COLLATE pg_catalog."default",
    CONSTRAINT rols_pkey PRIMARY KEY (id)
)

TABLESPACE pg_default;

ALTER TABLE IF EXISTS public.rols
    OWNER to postgres;