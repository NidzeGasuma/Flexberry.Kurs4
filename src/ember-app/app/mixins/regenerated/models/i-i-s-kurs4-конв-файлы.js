import Mixin from '@ember/object/mixin';
import $ from 'jquery';
import DS from 'ember-data';
import { validator } from 'ember-cp-validations';
import { attr, belongsTo, hasMany } from 'ember-flexberry-data/utils/attributes';

export let Model = Mixin.create({
  путьФайла: DS.attr('string'),
  выгрФайла: DS.belongsTo('i-i-s-kurs4-выгр-файла', { inverse: null, async: false })
});

export let ValidationRules = {
  путьФайла: {
    descriptionKey: 'models.i-i-s-kurs4-конв-файлы.validations.путьФайла.__caption__',
    validators: [
      validator('ds-error'),
    ],
  },
  выгрФайла: {
    descriptionKey: 'models.i-i-s-kurs4-конв-файлы.validations.выгрФайла.__caption__',
    validators: [
      validator('ds-error'),
      validator('presence', true),
    ],
  },
};

export let defineProjections = function (modelClass) {
  modelClass.defineProjection('КонвФайлыE', 'i-i-s-kurs4-конв-файлы', {
    путьФайла: attr('Путь файла', { index: 0 }),
    выгрФайла: belongsTo('i-i-s-kurs4-выгр-файла', 'Новое имя', {
      newName: attr('Новое имя', { index: 2, hidden: true }),
      конвертация: belongsTo('i-i-s-kurs4-конвертация', '', {
        имяДок: attr('Имя документа', { index: 3 }),
        загрФайла: belongsTo('i-i-s-kurs4-загр-файла', '', {
          эксФайлы: belongsTo('i-i-s-kurs4-экс-файлы', '', {
            имя: attr('Старое имя', { index: 4 })
          }, { index: -1, hidden: true })
        }, { index: -1, hidden: true })
      }, { index: -1, hidden: true })
    }, { index: 1, displayMemberPath: 'newName' })
  });

  modelClass.defineProjection('КонвФайлыL', 'i-i-s-kurs4-конв-файлы', {
    путьФайла: attr('Путь до файла', { index: 0 }),
    выгрФайла: belongsTo('i-i-s-kurs4-выгр-файла', 'Новое имя', {
      newName: attr('Новое имя', { index: 1 }),
      конвертация: belongsTo('i-i-s-kurs4-конвертация', '', {
        имяДок: attr('Имя документа', { index: 2 }),
        загрФайла: belongsTo('i-i-s-kurs4-загр-файла', '', {
          эксФайлы: belongsTo('i-i-s-kurs4-экс-файлы', '', {
            имя: attr('Старое имя', { index: 3 })
          }, { index: -1, hidden: true })
        }, { index: -1, hidden: true })
      }, { index: -1, hidden: true })
    }, { index: -1, hidden: true })
  });
};
